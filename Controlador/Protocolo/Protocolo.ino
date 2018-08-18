#include "Arduino.h"
#include "Protocolo.h"
#include "secundario.h"
#include "Executa.h"


Executa processo1;
void setup() {
  Ui.abreConexao(&Serial);
	pinMode(LED, OUTPUT);
	Ui.enviaValorSaidaDigital(estadoBotao[BOTAO1], ENDERECO_1);
	Ui.enviaValorSaidaDigital(estadoBotao[BOTAO2], ENDERECO_2);
	Ui.enviaTune(kp, ki, kd, periodo, sentido, ENDERECO_1);
	Ui.enviarAutoTune(passo, ruido, lookBack, estado, ENDERECO_1);
	Ui.enviaPid(referencia, entrada, saida, modo, ENDERECO_1);
}



void enviarGrafico(){
	Ui.enviaGrafico(referencia, random(25,50),  random(25,50), ENDERECO_1);
}

void (*resetFunc)(void) = 0;

void loop() {
	AguardaDadosSerial();
	processo1.aCadaMillisegundo(enviarGrafico, 500);	
}

