/*
 * decodificarString.cpp
 *
 *  Created on: 7 de jan de 2018
 *      Author: Georgines
 */

#include "decodificarString.h"

decodificarString::decodificarString() {
	// TODO Auto-generated constructor stub

}

decodificarString::~decodificarString() {
	// TODO Auto-generated destructor stub
}


String decodificarString::decodificaString(String response, String inicio, String fim){
	int start = response.indexOf(inicio);
		int end = response.indexOf(fim);

		if (start >= 0 && end >= 0) {
			return response.substring(start+1, end);
		} else {
			return F("#NAN#");
		}
}

