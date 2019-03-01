//set player one
const int playerOne = A0;
const int playerTwo = A1;

const int ledPinOne = 5;
const int ledPinTwo = 10;

int ledOneState = LOW;
int ledTwoState = LOW;

unsigned long previousMillis = 0;
const long interval = 100;
//sending a byte specific to the arduino
int incomingByte;
int flashesRemaining = 0;

bool oneIsFlashing = false;
bool twoIsFlashing = false;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(ledPinOne, OUTPUT);
}



void loop() {
  // put your main code here, to run repeatedly:
  unsigned long currentMillis = millis();
  if(Serial.available() > 0){
    incomingByte = Serial.read();

    //P = position,
    if(incomingByte == 'P'){
      sendPositions();
    }

    if(incomingByte == 'L'){
      oneIsFlashing = true;
      flashesRemaining = 6;
    }

    if(incomingByte == 'K'){
      twoIsFlashing = true;
      flashesRemaining = 6;
    }
  }
  
  if (flashesRemaining > 0)
  {
    if(currentMillis - previousMillis >= interval)
    {
      previousMillis = currentMillis;

      if (oneIsFlashing){
        if(ledOneState == LOW)
        {
          ledOneState = HIGH;
        }
        else
        {
          ledOneState = LOW;
        }
        digitalWrite(ledPinOne, ledOneState);
      }
      
      if (twoIsFlashing){
        if(ledTwoState == LOW)
        {
          ledTwoState = HIGH;
        }
        else
        {
          ledTwoState = LOW;
        }
        digitalWrite(ledPinTwo, ledTwoState);
      }
      
      flashesRemaining -= 1;
      if(flashesRemaining == 0){
        oneIsFlashing = false;
        twoIsFlashing = false;
      }
    }
  }
}



void sendPositions(){
  //set the value of Player 1 to position 1.
  int position1 = analogRead(playerOne);
  int position2 = analogRead(playerTwo);

  Serial.print(position1);
  Serial.print("-");
  Serial.println(position2);
}



