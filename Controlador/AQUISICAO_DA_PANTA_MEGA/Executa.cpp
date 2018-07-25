/*
 * Executa.cpp
 *
 *  Created on: 4 de jul de 2018
 *      Author: Georgines
 */

#include "Executa.h"
#ifndef Arduino_h
#include "Arduino.h"
#endif


void Executa::aCadaMillisegundo(void (*function)(void),
		unsigned int milisegundo) {

	if (millis() - ultimoTempo >= milisegundo) {

			function();


		ultimoTempo = millis();
	}
}

void Executa::aCadaSegundo(void (*function)(void), unsigned int segundo) {
	unsigned int milisegundo = (segundo * (1000));
	if (millis() - ultimoTempo >= milisegundo) {

			function();

		ultimoTempo = millis();
	}
}

void Executa::aCadaHora(void (*function)(void), unsigned int hora) {
	unsigned int milisegundo = (hora * (3600000));
	if (millis() - ultimoTempo >= milisegundo) {

			function();


		ultimoTempo = millis();
	}
}

