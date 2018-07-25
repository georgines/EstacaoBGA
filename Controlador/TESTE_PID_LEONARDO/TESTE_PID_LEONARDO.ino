#include "Arduino.h"
#include "max6675.h"

int thermoDO = A1;
int thermoCS = A0;
int thermoCLK = 15;
int potenciometro  = A3;

MAX6675 termopar1(thermoCLK, thermoCS, thermoDO);
int vccPin = 14;
int gndPin = 16;
int ventoinha = 6;

void setup() {
  Serial.begin(9600);
  // use Arduino pins
  pinMode(vccPin, OUTPUT); digitalWrite(vccPin, HIGH);
  pinMode(gndPin, OUTPUT); digitalWrite(gndPin, LOW);

  Serial.println("MAX6675 test");
  delay(500);
}

void loop() {


  int pot = analogRead(potenciometro);
  int velocidade = map(pot, 0, 1023,0,255);
  analogWrite(ventoinha, velocidade);
  Serial.println(pot);
//  Serial.println(thermocouple.readCelsius());


   delay(500);
}
