/*
 * Executa.h
 *
 *  Created on: 4 de jul de 2018
 *      Author: Usuario
 */

#ifndef EXECUTA_H_
#define EXECUTA_H_

class Executa {
public:
	void aCadaMillisegundo(void(*function)(void), unsigned int milisegundo);
	void aCadaSegundo(void(*function)(void), unsigned int segundo);
	void aCadaHora(void(*function)(void), unsigned int hora);
private:
  unsigned long tempoAtual;
  unsigned long ultimoTempo;
  bool mode;
};

#endif /* EXECUTA_H_ */
