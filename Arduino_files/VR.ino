#include <NewPing.h>
 
#define TRIGGER_PIN 11
#define ECHO_PIN 12
#define MAX_DISTANCE 200

// NewPing setup of pins and maximum distance
NewPing sonar(TRIGGER_PIN, ECHO_PIN, MAX_DISTANCE); 
int distanceN;
int distanceO;
int delta;

void setup() {
   Serial.begin(9600);
   pinMode(TRIGGER_PIN, OUTPUT);
   pinMode(ECHO_PIN, INPUT);
   distanceN = sonar.ping_cm();
   distanceO = distanceN;
}
 
void loop() {
   distanceN = sonar.ping_cm();
   delta = distanceN - distanceO;
   if(delta > 0 || delta < 0)
   {
    Serial.println(delta);
    delay(50);
   }
   else
   {
    Serial.println(99);
    delay(50);
   }
   distanceO = distanceN;
}
