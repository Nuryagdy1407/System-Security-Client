const int buzzer1 = 9;
const int buzzer2 = 8;



const int buttonPin = 2;     // the number of the pushbutton pin
const int buttonPin1 = 3;
const int buttonPin2 = 4;


const int ledPin =  13;      // the number of the LED pin
const int ledPin1 =  12;
const int ledPin2 =  11;

// variables will change:
int buttonState = 0;         // variable for reading the pushbutton status
int buttonState1 = 0; 
int buttonState2 = 0; 
void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
  pinMode(ledPin1, OUTPUT);
  pinMode(ledPin1, OUTPUT);
  pinMode(buzzer1, OUTPUT);
  pinMode(buzzer2, OUTPUT);
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin, INPUT_PULLUP);
  pinMode(buttonPin1, INPUT_PULLUP);
  pinMode(buttonPin2, INPUT_PULLUP);
  delay(1000);
}

void loop() {
  // read the state of the pushbutton value:
  buttonState = digitalRead(buttonPin);

  // check if the pushbutton is pressed. If it is, the buttonState is HIGH:
  if (buttonState == HIGH) {
    delay(1000);
    Serial.println("0");
    digitalWrite(ledPin, HIGH);
    digitalWrite(buzzer1, HIGH);
  } else {
    delay(1000);
//    Serial.println("1");
    digitalWrite(ledPin, LOW);
    digitalWrite(buzzer1, LOW);
  }
  sn1();
  sn2();
}

void sn1() {
  buttonState1 = digitalRead(buttonPin1);

  if (buttonState1 == HIGH) {
    delay(1000);
    Serial.println("1");
    digitalWrite(ledPin1, HIGH);
    digitalWrite(buzzer2, HIGH);
  } else {
    delay(1000);
//    Serial.println("ocya");
    digitalWrite(ledPin1, LOW);
    digitalWrite(buzzer2, LOW);
  }
}
int sana;
void sn2() {
  buttonState2 = digitalRead(buttonPin2);
  if (buttonState2 == HIGH) {
    delay(200);
    Serial.println("2");
    sana=sana+1;
    digitalWrite(ledPin2, HIGH);
    if (sana ==1){
    digitalWrite(buzzer2, HIGH);
    delay(1000);
    
    }
    if (sana ==6){
     sana =0;
    }
  } else {
    delay(200);
//    Serial.println("yandyaa");
    digitalWrite(ledPin2, LOW);
    digitalWrite(buzzer2, LOW);
    
  }
}
