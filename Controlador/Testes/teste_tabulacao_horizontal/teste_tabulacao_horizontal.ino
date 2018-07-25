#include <SoftwareSerial.h>

SoftwareSerial mySerial(2, 3); // RX, TX
void setup() {
 Serial.begin(9600);
 mySerial.begin(9600);
 

}

void loop() {

   char separador = '\t';
//  Serial.print("maria");
//  Serial.print("\t");
//
//  Serial.print("joao");
//  Serial.print("\t");
//  

  String identificador = "967";
  Serial.print(identificador);
  Serial.print(separador);

  
  double n1 =1;
  Serial.print(n1);
  Serial.print(separador);
  mySerial.print(n1);
  mySerial.print(separador);
  
  double n2 = random(1,5);
  Serial.print(n2);
  Serial.print(separador);
  mySerial.print(n2);
  mySerial.print(separador);


  double n3 = random(1,5);
  Serial.print(n3);
  Serial.print(separador);
  mySerial.print(n3);
  mySerial.print(separador);


  double n4 = random(1,5);
  Serial.print(n4);
  Serial.print(separador);
  mySerial.print(n4);
  mySerial.print(separador);

double n5 = random(1,5);
  Serial.print(n5);
  Serial.print(separador);
  mySerial.print(n5);
  mySerial.print(separador);

  double n6 = random(1,5);
  Serial.print(n6);
  Serial.print(separador);
  mySerial.print(n6);
  mySerial.print(separador);

 

  double n7 = random(1,5);
  Serial.print(n7);
  Serial.println();
  mySerial.print(n7);
  mySerial.println();

  delay(1000);

}
