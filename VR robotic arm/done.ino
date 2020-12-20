#include<Servo.h>
#include<math.h>
Servo my1,my2,my3;
float x,y,z;
void setup() {
  // put your setup code here, to run once:                                                                                                   
Serial.begin(9600);
my1.attach(10);
my2.attach(11);
my3.attach(6);
x=y=0.0;
z=26.7;
}

void loop() {
 double l1,l2;
 if(Serial.available()>0)
 {
  x=Serial.parseFloat();
  z=Serial.parseFloat();
  y=Serial.parseFloat();
 }
 l1=15.5;
 l2=11.2;
// x=-13.35;
// y=-13.35;
//z=18.879;
 double p,v,k,t,t1,t2,r;
 k=(l1*l1)+(l2*l2);
 p=(x*x)+(y*y)+(z*z);
 
 r=(p-k)/(2*l1*l2);
 
 if(r>1)
 {
  r=1;
 }
 if(r<0)
 {
  r=0;
 }
 t=acos(r);

 v=sqrt(pow((l1*cos(t)+l2),2)+pow(l1*sin(t),2));
 double f;
 f=asin(l1*sin(t)/v);
 
 t2=asin(z/v)-f;

 t1=t+t2;
 t1=(180/3.14)*t1;
 t2=(180/3.14)*t2;
 double a1,a2,a3;
 a1=90-t1+t2;
 a2=t1;
 if(x==0)
 {
  x=x+0.001;
 }
 a3=atan(y/x);
 a3=(180/3.14)*a3;
 if(x<0 && a3<0)
{
  a3=a3+180;
}
else if(y<0 && a3<0)
{
  a3=180+a3;
   
  a1=180-a1;
  a2=180-a2;
}
else if( x<0 && a3>0)
{
  
  a1=180-a1;
  a2=180-a2;
}
else
{
  ;
}
// Serial.println(a1);
// Serial.println(a3);
 my1.write(a1);
 my2.write(a2);
 my3.write(a3);
 
delay(5);
}
