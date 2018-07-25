/********************************************************
 * PID RelayOutput Example
 * Same as basic example, except that this time, the output
 * is going to a digital pin which (we presume) is controlling
 * a relay.  the pid is designed to Output an analog value,
 * but the relay can only be On/Off.
 *
 *   to connect them together we use "time proportioning
 * control"  it's essentially a really slow version of PWM.
 * first we decide on a window size (5000mS say.) we then
 * set the pid to adjust its output between 0 and that window
 * size.  lastly, we add some logic that translates the PID
 * output into "Relay On Time" with the remainder of the
 * window being "Relay Off Time"
 ********************************************************/

#include <PID_v1.h>
#include "max6675.h"

#define RELAY_PIN 4
#define POTENCIOMETRO A3
#define POTENCIOMETRO_VELOCIDADE_FAN A2



int thermoDO = A8;
int thermoCS = A9;
int thermoCLK = A10;
int vccPin = A11;
int gndPin = A12;


int thermoDO2 = A0;
int thermoCS2 = A1;
int thermoCLK2 = A2;
int vccPin2 = A3;
int gndPin2 = A4;

//int potenciometro  = A3;
//int potenciometro_velocidade  = A2;
int motor = 6;

MAX6675 thermocouple(thermoCLK, thermoCS, thermoDO);
MAX6675 thermocouple2(thermoCLK2, thermoCS2, thermoDO2);


double  Output;
int WindowSize = 2000;
unsigned long windowStartTime, inicio;
bool estado_rele = false;
int ref = 0;

void setup()
{
  Serial.begin(115200);
  Serial1.begin(115200);
  Serial1.setTimeout(10);
  pinMode(RELAY_PIN, OUTPUT);
  digitalWrite(RELAY_PIN, LOW);
  
  pinMode(vccPin, OUTPUT);
  digitalWrite(vccPin, HIGH);
  pinMode(gndPin, OUTPUT);
  digitalWrite(gndPin, LOW);

  pinMode(vccPin2, OUTPUT);
  digitalWrite(vccPin2, HIGH);
  pinMode(gndPin2, OUTPUT);
  digitalWrite(gndPin2, LOW);
  
  delay(500);
 
}

void loop()
{

//  int pot = analogRead(POTENCIOMETRO);
//  int Output = map(pot, 0, 100,WindowSize,0);
//  int porcentagem = map(pot, 0, 1023,0,100);


//  int pot_vel_fan = analogRead(POTENCIOMETRO_VELOCIDADE_FAN);
//  int velocidade = map(pot_vel_fan, 0, 1023,0,255);
  int velocidade = 79; //30%
//  int porcentagem_fan = map(pot_vel_fan, 0, 1023,0,100);
int porcentagem_fan  = 30;
  analogWrite(motor, velocidade);

//    Serial.print(porcentagem);
//  Serial.println("%");

  
  
 
  if(Serial1.available()){
    String s = Serial1.readString();
    ref = s.toInt(); 
  }
  
  int Output = map(ref, 0, 100,WindowSize,0);
  int tempo_total = 2000;
  
  if (millis() - inicio > tempo_total)
  { 
     //ENTRADA
     if(estado_rele == true){
       Serial.print(10);
     }else{
       Serial.print(0);
     }
          
     //SAIDA
     Serial.print("\t");
     Serial.print(thermocouple.readCelsius());
     
     Serial.print("\t");
     Serial.print(thermocouple2.readCelsius());

     //PORCENTAGEM SAIDA
     Serial.print("\t");
     Serial.print(ref);     

     //PORCENTAGEM VELOCIDADE MOTOR
     Serial.print("\t");
     Serial.print(porcentagem_fan);      

     Serial.println();

    inicio += tempo_total;
  }

   if (millis() - windowStartTime > WindowSize)
  { 
    windowStartTime += WindowSize;
  }
  
  if (Output < millis() - windowStartTime){
    digitalWrite(RELAY_PIN, HIGH);
    estado_rele = true;   
  } else {
    digitalWrite(RELAY_PIN, LOW);
    estado_rele = false;
  }
 

}



