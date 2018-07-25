/*
 * Protocolo.cpp
 *
 *  Created on: 13 de jul de 2018
 *      Author: Usuario
 */

#include "Protocolo.h"

void Protocolo::enviarProtocolo() {
	String dados;
	for (int i = 0; i < 8; i++) {
		dados += String(this->dadosEnvio[i]);
		if (i < 7) {
			dados += String(this->separador);
		}
		if (i == 7) {
			dados += "\r\n";
		}
	}
	porta->print(dados);
	//porta->print("4\t1\t52\t0\t0\t0\t0\t0\r\n");
}

void Protocolo::liparVariavelEnvio() {
	for (int i = 0; i < 8; i++) {
		this->dadosEnvio[i] = 0;
	}
}

bool Protocolo::seDisponivelDecodifica() {
	if (porta->available()) {
		String dados = porta->readString();
		String temporario;
		for (int i = 0; i < 8; i++) {
			temporario = dividirEmOitoPartes(dados, i);
			this->dadosRecebido[i] = temporario.toFloat();
		}
		return true;
	}
	return false;
}

float Protocolo::pegarValor(int numero) {
	if (numero < 8) {
		return this->dadosRecebido[numero];
	}
	return -1;
}

void Protocolo::imprimirValor(int numero) {
	if (numero < 8) {
		this->porta->print(this->pegarValor(numero));
	}
}

void Protocolo::pularUmaLinha() {
	this->porta->println();
}

int Protocolo::lerId() {
	return (int) this->dadosRecebido[B_ID];
}

int Protocolo::lerEndereco() {
	return (int) this->dadosRecebido[B_ENDERECO];
}

int Protocolo::lerValorSaidaDigital() {
	return (int) this->dadosRecebido[B_VALOR_SAIDA_DIGITAL];
}
void Protocolo::enviaValorSaidaDigital(int valor, int endereco) {
	this->liparVariavelEnvio();
	this->dadosEnvio[B_ID] = ID_SAIDA_DIGITAL;
	this->dadosEnvio[B_ENDERECO] = endereco;
	this->dadosEnvio[B_VALOR_SAIDA_DIGITAL] = valor;
	this->enviarProtocolo();
}

int Protocolo::lerValorPWM() {
	return (int) this->dadosRecebido[B_VALOR_PWM];
}

void Protocolo::enviaValorPWM(int valor, int endereco) {
	this->liparVariavelEnvio();
	this->dadosEnvio[B_ID] = ID_PWM;
	this->dadosEnvio[B_ENDERECO] = endereco;
	this->dadosEnvio[B_VALOR_PWM] = valor;
	this->enviarProtocolo();
}

float Protocolo::lerTune(int posicao) {
	return this->dadosRecebido[posicao];
}

void Protocolo::enviaTune(float kp, float ki, float kd, int periodo,
		int sentido, int endereco) {
	this->liparVariavelEnvio();
	this->dadosEnvio[B_ID] = ID_TUNE;
	this->dadosEnvio[B_ENDERECO] = endereco;
	this->dadosEnvio[B_KP] = kp;
	this->dadosEnvio[B_KI] = ki;
	this->dadosEnvio[B_KD] = kd;
	this->dadosEnvio[B_SENTIDO] = sentido;
	this->dadosEnvio[B_PERIODO] = periodo;
	this->enviarProtocolo();
}

float Protocolo::lerPid(int posicao) {
	return this->dadosRecebido[posicao];
}

void Protocolo::enviaPid(float referencia, float entrada, float saida, int modo,
		int endereco) {
	this->liparVariavelEnvio();
	this->dadosEnvio[B_ID] = ID_PID;
	this->dadosEnvio[B_ENDERECO] = endereco;
	this->dadosEnvio[B_REFERENCIA] = referencia;
	this->dadosEnvio[B_ENTRADA] = entrada;
	this->dadosEnvio[B_SAIDA] = saida;
	this->dadosEnvio[B_MODO] = modo;
	this->enviarProtocolo();
}

float Protocolo::lerAutoTune(int posicao) {
	return this->dadosRecebido[posicao];
}

void Protocolo::enviarAutoTune(float passo, float ruido, float lookBack,
		int estado, int endereco) {
	this->liparVariavelEnvio();
	this->dadosEnvio[B_ID] = ID_AUTO_TUNE;
	this->dadosEnvio[B_ENDERECO] = endereco;
	this->dadosEnvio[B_STEP] = passo;
	this->dadosEnvio[B_NOISE] = ruido;
	this->dadosEnvio[B_LOOK_BACK] = lookBack;
	this->dadosEnvio[B_STATUS_A_TUNE] = estado;
	this->enviarProtocolo();
}

void Protocolo::enviaGrafico(float entrada, float referencia, float saida,
		int endereco) {
	this->liparVariavelEnvio();
		this->dadosEnvio[B_ID] = ID_GRAFICO;
		this->dadosEnvio[B_ENDERECO] = endereco;
		this->dadosEnvio[B_ENTRADA] = entrada;
		this->dadosEnvio[B_REFERENCIA] = referencia;
		this->dadosEnvio[B_SAIDA] = saida;
		this->enviarProtocolo();

}

int Protocolo::lerControleMicro(int posicao) {
	return (int)this->dadosRecebido[posicao];
}

String Protocolo::dividirEmOitoPartes(String dados, int indiceAtual) {

	int encontrado = 0;
	int indiceDaString[] = { 0, -1 };
	int maximoIndiceDaString = dados.length() - 1;

	for (int i = 0; i <= maximoIndiceDaString && encontrado <= indiceAtual;
			i++) {
		if (dados.charAt(i) == this->separador || i == maximoIndiceDaString) {
			encontrado++;
			indiceDaString[0] = indiceDaString[1] + 1;
			indiceDaString[1] = (i == maximoIndiceDaString) ? i + 1 : i;
		}
	}
	return encontrado > indiceAtual ?
			dados.substring(indiceDaString[0], indiceDaString[1]) : "";
}

