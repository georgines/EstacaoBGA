#include "Arduino.h"
#include <PID_v1.h>
#include <PID_AutoTune_v0.h>
#include "max6675.h"
#include "Executa.h"

#define PINO_RELE 4

int thermoDO = A8;
int thermoCS = A9;
int thermoCLK = A10;
int vccPin = A11;
int gndPin = A12;

double temperatura1 = 0;

int ventoinha = 6;
int porcentagem_ventoinha = 0;
int porcentagem_aquecedor = 0;
int velocidade_ventoinha = 80;

unsigned int periodo_total_CPT = 2000;
unsigned int periodo_atualizacao_serial = 250;
unsigned int periodo_atualizacao_termopar = 250;
unsigned long periodo_inicial_CTP = 0;
unsigned long periodo_inicial_atualizacao_serial = 0;
unsigned int periodo_ligado_CTP = periodo_total_CPT;
MAX6675 termopar1(thermoCLK, thermoCS, thermoDO);
Executa processo1;

byte ATuneModeRemember = 2;
double input = 80, output = 50, setpoint = 180;
//double kp = 2, ki = 0.5, kd = 2;
double kp = 5, ki = 0.5, kd = 2;

double kpmodel = 1.5, taup = 100, theta[50];
double outputStart = 5;

double aTuneStep = 50, aTuneNoise = 1, aTuneStartValue = 100;
unsigned int aTuneLookBack = 20;

boolean tuning = false;
unsigned long modelTime, serialTime;

PID myPID(&input, &output, &setpoint, kp, ki, kd, DIRECT);
PID_ATune aTune(&input, &output);

//set to false to connect to the real world
boolean useSimulation = true;

void ler_termopar(void) {
	temperatura1 = termopar1.readCelsius();

}

void setup() {

	pinMode(PINO_RELE, OUTPUT);
	digitalWrite(PINO_RELE, LOW);

	pinMode(vccPin, OUTPUT);
	digitalWrite(vccPin, HIGH);
	pinMode(gndPin, OUTPUT);
	digitalWrite(gndPin, LOW);

	delay(500);

	if (useSimulation) {
		for (byte i = 0; i < 50; i++) {
			theta[i] = outputStart;
		}
		modelTime = 0;
	}
	//Setup the pid
	myPID.SetMode(AUTOMATIC);
	myPID.SetOutputLimits(0,periodo_total_CPT );

	if (tuning) {
		tuning = false;
		changeAutoTune();
		tuning = true;
	}

	serialTime = 0;
	Serial.begin(9600);

}

void loop() {

	unsigned long now = millis();

	if (!useSimulation) { //pull the input in from the real world
		analogWrite(ventoinha, velocidade_ventoinha);
		processo1.aCadaMillisegundo(ler_termopar, periodo_atualizacao_termopar);
		input = temperatura1;
//		input = analogRead(0);
	}

	if (tuning) {
		byte val = (aTune.Runtime());
		if (val != 0) {
			tuning = false;
		}
		if (!tuning) { //we're done, set the tuning parameters
			kp = aTune.GetKp();
			ki = aTune.GetKi();
			kd = aTune.GetKd();
			myPID.SetTunings(kp, ki, kd);
			AutoTuneHelper(false);
		}
	} else {
		myPID.Compute();
	}

	if (useSimulation) {
		theta[30] = output;
		if (now >= modelTime) {
			modelTime += 100;
			DoModel();
		}
	} else {

		if (millis() - periodo_inicial_CTP > periodo_total_CPT) {
			periodo_inicial_CTP += periodo_total_CPT;
		}

		if (output < millis() - periodo_inicial_CTP) {
			digitalWrite(PINO_RELE, HIGH);

		} else {
			digitalWrite(PINO_RELE, LOW);

		}
//		analogWrite(6, output);
	}

	//send-receive with processing if it's time
	if (millis() > serialTime) {
		SerialReceive();
		SerialSend();
		serialTime += 500;
	}
}

void changeAutoTune() {
	if (!tuning) {
		//Set the output to the desired starting frequency.
		output = aTuneStartValue;
		aTune.SetNoiseBand(aTuneNoise);
		aTune.SetOutputStep(aTuneStep);
		aTune.SetLookbackSec((int) aTuneLookBack);
		AutoTuneHelper(true);
		tuning = true;
	} else { //cancel autotune
		aTune.Cancel();
		tuning = false;
		AutoTuneHelper(false);
	}
}

void AutoTuneHelper(boolean start) {
	if (start)
		ATuneModeRemember = myPID.GetMode();
	else
		myPID.SetMode(ATuneModeRemember);
}

void SerialSend() {
	Serial.print("setpoint: ");
	Serial.print(setpoint);
	Serial.print(" ");
	Serial.print("input: ");
	Serial.print(input);
	Serial.print(" ");
	Serial.print("output: ");
	Serial.print(output);
	Serial.print(" ");
	if (tuning) {
		Serial.println("tuning mode");
	} else {
		Serial.print("kp: ");
		Serial.print(myPID.GetKp());
		Serial.print(" ");
		Serial.print("ki: ");
		Serial.print(myPID.GetKi());
		Serial.print(" ");
		Serial.print("kd: ");
		Serial.print(myPID.GetKd());
		Serial.println();
	}
}

void SerialReceive() {
	if (Serial.available()) {
		char b = Serial.read();
		Serial.flush();
		if ((b == '1' && !tuning) || (b != '1' && tuning))
			changeAutoTune();
	}
}

void DoModel() {
	//cycle the dead time
	for (byte i = 0; i < 49; i++) {
		theta[i] = theta[i + 1];
	}
	//compute the input
	input = (kpmodel / taup) * (theta[0] - outputStart) + input * (1 - 1 / taup)
			+ ((float) random(-10, 10)) / 100;

}
