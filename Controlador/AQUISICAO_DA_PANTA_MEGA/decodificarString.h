/*
 * decodificarString.h
 *
 *  Created on: 7 de jan de 2018
 *      Author: Georgines
 */

#ifndef DECODIFICARSTRING_H_
#define DECODIFICARSTRING_H_

#ifndef Arduino_h
#include <Arduino.h>
#endif

class decodificarString {
public:
	decodificarString();
	String decodificaString(String response, String incio, String fim);
	virtual ~decodificarString();
};

#endif /* DECODIFICARSTRING_H_ */
