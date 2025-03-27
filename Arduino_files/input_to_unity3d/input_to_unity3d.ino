float i,j,k;

void setup() {
pinMode(LED_BUILTIN,OUTPUT);
Serial.begin(9600);
}

void loop() {
if(Serial.available()>0)
{
  i=Serial.parseFloat();
  k=Serial.parseFloat();
  j=Serial.parseFloat();
  if (k > 200.0)
  digitalWrite(LED_BUILTIN,HIGH);
  else
  digitalWrite(LED_BUILTIN,LOW);
}
delay(5);
}
