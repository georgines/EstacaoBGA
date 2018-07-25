/*
 * Protocolo.h
 *
 *  Created on: 13 de jul de 2018
 *      Author: Usuario
 */
#include "Arduino.h"
#ifndef PROTOCOLO_H_
#define PROTOCOLO_H_

#define ID_PID 1
#define ID_TUNE 2
#define ID_AUTO_TUNE 3
#define ID_PWM 4
#define ID_SAIDA_DIGITAL 5
#define ID_GRAFICO 967
#define B_ENDERECO 1
#define ENDERECO_1 1
#define ENDERECO_2 2
#define ENDERECO_3 3
#define ENDERECO_4 4
#define AUTOMATICO 1
#define MANUAL 0
#define NADA 0
#define DIRETO 1
#define REVERSO 0
#define LIGADO 1
#define DESLIGADO 0
#define B_ID 0
#define B_VALOR_SAIDA_DIGITAL 2
#define B_VALOR_PWM 2
#define B_KP 2
#define B_KI 3
#define B_KD 4
#define B_SENTIDO 5
#define B_PERIODO 6
#define B_STEP 2
#define B_NOISE 3
#define B_LOOK_BACK 4
#define B_STATUS_A_TUNE 5
#define B_ENTRADA 3
#define B_REFERENCIA 2
#define B_SAIDA 4
#define B_MODO 5
#define ID_RESET 0
#define BT_RESET_MICRO 3



class Protocolo {
public:
//	Protocolo();
	void enviarProtocolo();
	void liparVariavelEnvio();bool seDisponivelDecodifica();
	float pegarValor(int numero);
	void imprimirValor(int numero);
	void pularUmaLinha();
	int lerId();
	int lerEndereco();
	int lerValorSaidaDigital();
	void enviaValorSaidaDigital(int valor, int endereco);
	int lerValorPWM();
	void enviaValorPWM(int valor, int endereco);
	float lerTune(int posicao);
	void enviaTune(float kp, float ki, float kd, int periodo, int sentido, int endereco);
	float lerPid(int posicao);
	void enviaPid(float referencia, float entrada, float saida, int modo, int endereco);
	float lerAutoTune(int posicao);
	void enviarAutoTune(float passo, float ruido, float lookBack, int estado, int endereco);
	void enviaGrafico(float entrada, float referencia, float saida, int endereco);
	int lerControleMicro(int posicao);

	float dadosEnvio[8];

private:

	char separador = '\t';
	float dadosRecebido[8];
	int bauDrate;
	HardwareSerial* porta;
	String dividirEmOitoPartes(String dados, int indiceAtual);

public:

	void abreConexao(HardwareSerial *porta, int bauDate = 9600) {
		this->porta = porta;
		this->bauDrate = bauDate;
		this->porta->begin(bauDate);
		this->porta->setTimeout(10);
	}

	void setSeparador(char separador) {
		this->separador = separador;
	}

	HardwareSerial* getPorta() {
		return porta;
	}
};
#endif /* PROTOCOLO_H_ */
