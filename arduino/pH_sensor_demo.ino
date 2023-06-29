
#include "DHT.h"  

#define SensorPin 0    
#define pressure 1  
#define soil_moisture 2 
#define Valvepin A5 
#define DHTPIN 6        // DHT sensor data pin
#define DHTTYPE DHT11   //include DHT type
#define kpa2atm 0.00986923267 
#define Speaker A4

unsigned long int avgValue;  //Store the average value of the sensor feedback
float b;
int buf[10],temp;
int val;    // variables defining
float pkPa; // pressure in kPa
float pAtm; // pressure in Atm


DHT dht(DHTPIN, DHTTYPE); //define DHT function
void setup()
{
  Serial.begin(9600);  
  dht.begin(); 
  pinMode(soil_moisture, INPUT); //start soil moisture sensor
  pinMode(Valvepin, OUTPUT);     //valve pin
  pinMode(Speaker, OUTPUT);     //valve pin
 
  
}
void loop()

{
  if (Serial.available()>0)
  {
    String command = Serial.readStringUntil('\n');
    if (command == "Send Data")
   {
      float Relative_Humidity = dht.readHumidity();       //Read the humidity 
      float Absolute_Temperature = dht.readTemperature(); //Read the temperature

  if(isnan(Relative_Humidity) || isnan(Absolute_Temperature))     //Adding failsafe for NaN values
  {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }
  else{
  //Serial.print("Hum: ");           //print H and T
  Serial.println(Relative_Humidity*10);      //print H and T
 // Serial.print("Temperature: ");      //print H and T
  Serial.println(Absolute_Temperature*10);} //print H and T

  float moisture = analogRead(soil_moisture);       //getting soil moisture
  moisture = (moisture/1023)*100;       //getting soil moisture

  if(isnan(moisture))                           //Adding failsafe for NaN values
  {
    Serial.println("Failed to read from soil misture sensor!");
    return;
  }
  
  else{
  //Serial.print("Soil mositure: ");            //printing soil moisture
  Serial.println(moisture);                   //printing soil moisture
  //Serial.println(" %");}                //printing soil moisture
  }
  for(int i=0;i<10;i++)       //Get 10 sample value from the sensor for smooth the value
  { 
    buf[i]=analogRead(SensorPin);
    
  }
  for(int i=0;i<9;i++)        //sort the analog from small to large
  {
    for(int j=i+1;j<10;j++)
    {
      if(buf[i]>buf[j])
      {
        temp=buf[i];
        buf[i]=buf[j];
        buf[j]=temp;
      }
    }
  }
  avgValue=0;
  for(int i=2;i<8;i++)                      //take the average value of 6 center sample
    avgValue+=buf[i];
  float phValue=(float)avgValue*5.0/1024/6; //convert the analog into millivolt
  phValue=3.5*phValue;                      //convert the millivolt into pH value
  //Serial.print("pH:");  
  Serial.println(phValue,2);
    
  
  val = analogRead(pressure);                  //getting pressure
  pkPa = ((float)val/(float)1023+0.095)/0.009; //getting pressure
  pAtm = kpa2atm*pkPa;                         //getting pressure

  if(isnan(pressure))     //Adding failsafe for NaN values
  {
    Serial.println("Failed to read from pressure sensor!");
    return;
  }

  else{
  //Serial.print("Pressure in ka: ");                         //printing pressure
  Serial.println(pkPa);                         //printing pressure                        //printing pressure
  Serial.println(pAtm);} 
   }
if (command == "Polish Plants"){
    digitalWrite(Valvepin, HIGH);     //condition for motor to start
    tone(Speaker, 262, 200);   // Play the frequency 262 Hz for 200 milliseconds
    delay(300);                   // Delay between notes
    tone(Speaker, 294, 200);
    delay(300);
    tone(Speaker, 330, 200);
    delay(300);
    digitalWrite(Valvepin, LOW);//printing pressure
    noTone(Speaker); 
    

}
}
}
