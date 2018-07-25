#define PWM 10
#define POT  A0
void setup() {
  pinMode(PWM, OUTPUT);
}

void loop() {

  int velocidade = map(analogRead(POT),0,1023,0,255);
  analogWrite(PWM, velocidade);

}
