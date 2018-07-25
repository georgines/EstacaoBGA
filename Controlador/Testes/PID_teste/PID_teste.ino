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

int thermoDO = A1;
int thermoCS = A0;
int thermoCLK = 15;
int vccPin = 14;
int gndPin = 16;

int motor = 6;

MAX6675 thermocouple(thermoCLK, thermoCS, thermoDO);

//Define Variables we'll be connecting to
double Setpoint, Input, Output;

//Specify the links and initial tuning parameters
double Kp=0.006378787938601, Ki=48.648034348604370, Kd=0.009499448112144;
//double Kp=15, Ki=0, Kd=0;
PID myPID(&Input, &Output, &Setpoint, Kp, Ki, Kd, DIRECT);
//PID myPID(&Input, &Output, &Setpoint, Kp, Ki, Kd, REVERSE);

int WindowSize = 2000;
unsigned long windowStartTime, inicio;
bool estado_rele = false;

void setup()
{
  Serial.begin(115200);
  pinMode(RELAY_PIN, OUTPUT);
  digitalWrite(RELAY_PIN, LOW);
  pinMode(vccPin, OUTPUT); digitalWrite(vccPin, HIGH);
  pinMode(gndPin, OUTPUT); digitalWrite(gndPin, LOW);
  delay(500);
  
  windowStartTime = millis();

  //initialize the variables we're linked to
  Setpoint = 100;

  //tell the PID to range between 0 and the full window size
  myPID.SetOutputLimits(0, WindowSize);

  //turn the PID on
  myPID.SetMode(AUTOMATIC);
}

void loop()
{
  

  int pot = analogRead(POTENCIOMETRO);
  int Setpoint = map(pot, 0, 1023,0 ,300); 

  int pot_vel_fan = analogRead(POTENCIOMETRO_VELOCIDADE_FAN);
  int velocidade = map(pot_vel_fan, 0, 1023,0,255);
  int porcentagem_fan = map(pot_vel_fan, 0, 1023,0,100);
  analogWrite(motor, velocidade);


  int tempo_total = 500;
  
  if (millis() - inicio > tempo_total)
  { 
     //SAIDA
     if(estado_rele == true){
       Serial.print(10);
     }else{
       Serial.print(0);
     }
          
     //ENTRADA
     Serial.print("\t");
     Input = thermocouple.readCelsius();
     Serial.print(Input);

     //SETPOINT
     Serial.print("\t");
     Serial.print(Setpoint);     

     //PORCENTAGEM VELOCIDADE MOTOR
     Serial.print("\t");
     Serial.print(porcentagem_fan);      

     Serial.println();

    inicio += tempo_total;
  }

  myPID.Compute();

  /************************************************
   * turn the output pin on/off based on pid output
   ************************************************/
  if (millis() - windowStartTime > WindowSize)
  { //time to shift the Relay Window
    windowStartTime += WindowSize;
  }
  if (Output < millis() - windowStartTime){
    digitalWrite(RELAY_PIN, HIGH);
    estado_rele = true;
  }  else {
    estado_rele = false;
    digitalWrite(RELAY_PIN, LOW);
  }

}



