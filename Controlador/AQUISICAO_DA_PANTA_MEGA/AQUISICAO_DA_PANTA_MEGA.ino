#include "Arduino.h"
#include "decodificarString.h"
#include "Executa.h"
#include <PID_v1.h>
#include "max6675.h"

#define PINO_RELE 6

int thermoDO = 12;
int thermoCS = 10;
int thermoCLK = 13;
//int vccPin = A11;
//int gndPin = A12;

//int thermoDO2 = A0;
//int thermoCS2 = A1;
//int thermoCLK2 = A2;
//int vccPin2 = A3;
//int gndPin2 = A4;

int ventoinha = 4;
int porcentagem_ventoinha = 0;
int porcentagem_aquecedor = 0;
int velocidade_ventoinha = 0;

double temperatura1 = 0;
double temperatura2 = 0;

MAX6675 termopar1(thermoCLK, thermoCS, thermoDO);
//MAX6675 termopar2(thermoCLK2, thermoCS2, thermoDO2);
decodificarString dadosBrutos;
Executa processo1;
Executa processo2;

unsigned int periodo_total_CPT = 2000;
unsigned int periodo_atualizacao_serial = 1000;
unsigned int periodo_atualizacao_termopar = 250;
unsigned long periodo_inicial_CTP = 0;
unsigned long periodo_inicial_atualizacao_serial = 0;
unsigned int periodo_ligado_CTP = periodo_total_CPT; //tempo ligado na saida

//flags
bool estado_rele = false;
bool fazer_calculo_ventoinha = false;
bool fazer_calculo_aquecedor = false;
bool serial_on = true;

void enviar_pela_serial(void) {
	if (serial_on) {
		//ENTRADA
//		if (estado_rele == true) {
//			Serial.print(10);
//		} else {
//			Serial.print(0);
//		}
		Serial.print(porcentagem_aquecedor);

		//SAIDA
		Serial.print("\t");
		Serial.print(temperatura1);
//		Serial.print("\t");
//		Serial.print(temperatura1);

		//PORCENTAGEM SAIDA
//		Serial.print("\t");


		//PORCENTAGEM VELOCIDADE MOTOR
//		Serial.print("\t");
//		Serial.print(porcentagem_ventoinha);

		Serial.println();

	}
}
void ler_termopar(void) {
	temperatura1 = termopar1.readCelsius();
//	temperatura2 = termopar2.readCelsius();
}

void lerComandoDaSerial() {
	if (Serial1.available()) {

		String raw = Serial1.readString();
		String funcao = dadosBrutos.decodificaString(raw, F("@"), F(">"));

		if (funcao == F("aquecedor")) {
			porcentagem_aquecedor = dadosBrutos.decodificaString(raw, F(">"),
					F("%")).toInt();
			fazer_calculo_aquecedor = true;
		}
		if (funcao == F("ventoinha")) {
			porcentagem_ventoinha = dadosBrutos.decodificaString(raw, F(">"),
					F("%")).toInt();
			fazer_calculo_ventoinha = true;
		}
		if (funcao == F("atualizacao_serial")) {
			periodo_atualizacao_serial = dadosBrutos.decodificaString(raw,
					F(">"), F(";")).toInt();
		}
		if (funcao == F("atualizacao_termopar")) {
			periodo_atualizacao_termopar = dadosBrutos.decodificaString(raw,
					F(">"), F(";")).toInt();
		}
		if (funcao == F("perido_cpt")) {
			periodo_total_CPT = dadosBrutos.decodificaString(raw, F(">"),
					F(";")).toInt();
		}
		if (funcao == F("desligar")) {
			porcentagem_ventoinha = 0;
			porcentagem_aquecedor = 0;
			fazer_calculo_aquecedor = true;
			fazer_calculo_ventoinha = true;
			serial_on = false;
		}
		if (funcao == F("serial_on")) {
			serial_on = true;
		}
		if (funcao == F("serial_off")) {
			serial_on = false;
		}

	}
}

void realizaCalculosSimples() {
	//só calcula quando solicitado
	if (fazer_calculo_ventoinha) {
		velocidade_ventoinha = map(porcentagem_ventoinha, 0, 100, 0, 255);
		fazer_calculo_ventoinha = false;
	}

	if (fazer_calculo_aquecedor) {
		periodo_ligado_CTP = map(porcentagem_aquecedor, 0, 100,
				periodo_total_CPT, 0);
		fazer_calculo_aquecedor = false;
	}
}

void setup() {

	Serial.begin(115200);
	Serial.setTimeout(10);
	Serial1.begin(115200);
	Serial1.setTimeout(10);

	pinMode(PINO_RELE, OUTPUT);
	digitalWrite(PINO_RELE, LOW);

//	pinMode(vccPin, OUTPUT);
//	digitalWrite(vccPin, HIGH);
//	pinMode(gndPin, OUTPUT);
//	digitalWrite(gndPin, LOW);
//
//	pinMode(vccPin2, OUTPUT);
//	digitalWrite(vccPin2, HIGH);
//	pinMode(gndPin2, OUTPUT);
//	digitalWrite(gndPin2, LOW);

	delay(500);

}

//funcoes

void loop() {

	lerComandoDaSerial();
	realizaCalculosSimples();
	//escreve no PWM a velocidade desejada
	analogWrite(ventoinha, velocidade_ventoinha);
	processo1.aCadaMillisegundo(enviar_pela_serial, periodo_atualizacao_serial);
	processo2.aCadaMillisegundo(ler_termopar, periodo_atualizacao_termopar);

	if (millis() - periodo_inicial_CTP > periodo_total_CPT) {
		periodo_inicial_CTP += periodo_total_CPT;
	}

	if (periodo_ligado_CTP < millis() - periodo_inicial_CTP) {
		digitalWrite(PINO_RELE, HIGH);
		estado_rele = true;
	} else {
		digitalWrite(PINO_RELE, LOW);
		estado_rele = false;
	}

}

