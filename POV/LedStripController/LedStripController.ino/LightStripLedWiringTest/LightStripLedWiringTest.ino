int pins[] = {2,3,4,5,6,7,8,9};

void setup() {
  for(int i=0; i<sizeof(pins)/sizeof(int); i++){
    pinMode(pins[i], OUTPUT);
  }
  Serial.begin(9600);
}

void loop() {
  for(int i=0; i<sizeof(pins)/sizeof(int);i++) { 
    AllOff(); 
    digitalWrite(pins[i], HIGH); 
    delay(1000); 
  }
}

void AllOff(){
  for (int i=0; i<sizeof(pins)/sizeof(int);i++) {
    digitalWrite(pins[i], LOW); 
  }
}
