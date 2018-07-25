/*
 * secundario.h
 *
 *  Created on: 13 de jul de 2018
 *      Author: Usuario
 */
#include "Arduino.h"
#ifndef SECUNDARIO_H_
#define SECUNDARIO_H_

#define LED 13
#define FAN 7
#define FAN_2 8

#define BOTAO1 0
#define BOTAO2 1

float kp = 2;
float ki = 0.5;
float kd = 2;
int periodo = 5;
int sentido = DIRETO;

float passo = 10;
float ruido = 0.1;
float lookBack = 20;
int estado = DESLIGADO;

float referencia = 50;
float entrada = 25;
float saida = 5;
int modo = MANUAL;
//
int estadoBotao[2] = { 0 };
//

bool reset_micro = false;

Protocolo Ui;

void _SaidasDigitais() {
	switch (Ui.lerEndereco()) {
	case ENDERECO_1:
		if (Ui.lerValorSaidaDigital()) {
			digitalWrite(LED, HIGH);
		} else {
			digitalWrite(LED, LOW);
		}
		break;
	case ENDERECO_2:
		if (Ui.lerValorSaidaDigital()) {

		} else {

		}
		break;
	}
}

void _Pwm() {
	int pwm;
	switch (Ui.lerEndereco()) {
	case ENDERECO_1:
		pwm = Ui.lerValorPWM();
		analogWrite(FAN, pwm);
		Ui.enviaValorPWM(pwm, ENDERECO_1);
		break;
	case ENDERECO_2:
		pwm = Ui.lerValorPWM();
		analogWrite(FAN_2, pwm);
		Ui.enviaValorPWM(pwm, ENDERECO_2);
		break;
	}
}

void _PID() {
	switch (Ui.lerEndereco()) {
	case ENDERECO_1:
		referencia = Ui.lerTune(B_REFERENCIA);
		entrada = Ui.lerTune(B_ENTRADA);
		saida = Ui.lerTune(B_SAIDA);
		modo = (int) Ui.lerTune(B_MODO);

		Ui.enviaPid(referencia, entrada, saida, modo, ENDERECO_1);
		break;
	case ENDERECO_2:

		break;
	}
}
void _Tune() {
	switch (Ui.lerEndereco()) {
	case ENDERECO_1:
		kp = Ui.lerPid(B_KP);
		ki = Ui.lerPid(B_KI);
		kd = Ui.lerPid(B_KD);
		periodo = (int) Ui.lerPid(B_PERIODO);
		sentido = (int) Ui.lerPid(B_SENTIDO);
		Ui.enviaTune(kp, ki, kd, periodo, sentido, ENDERECO_1);
		break;
	case ENDERECO_2:

		break;
	}
}
void _AutoTune() {
	switch (Ui.lerEndereco()) {
	case ENDERECO_1:
		passo = Ui.lerAutoTune(B_STEP);
		ruido = Ui.lerAutoTune(B_NOISE);
		lookBack = Ui.lerAutoTune(B_LOOK_BACK);
		estado = Ui.lerAutoTune(B_STATUS_A_TUNE);
		Ui.enviarAutoTune(passo, ruido, lookBack, estado, ENDERECO_1);
		break;
	case ENDERECO_2:

		break;
	}
}
void _Grafico() {
	switch (Ui.lerEndereco()) {
	case ENDERECO_1:

		break;
	case ENDERECO_2:

		break;
	}
}

void _Reset(){
	if(Ui.lerControleMicro(BT_RESET_MICRO) == 1853){
		reset_micro = true;
	}

}

void AguardaDadosSerial() {
	if (Ui.seDisponivelDecodifica()) {
		switch (Ui.lerId()) {
		case ID_RESET:
			_Reset();
			break;
		case ID_PID:
			_PID();
			break;
		case ID_TUNE:
			_Tune();
			break;
		case ID_AUTO_TUNE:
			_AutoTune();
			break;
		case ID_PWM:
			_Pwm();
			break;
		case ID_SAIDA_DIGITAL:
			_SaidasDigitais();
			break;
		case ID_GRAFICO:
			_Grafico();
			break;
		default:
			break;
		}
	}
}

#endif /* SECUNDARIO_H_ */
