int pinRead = 6,
    previnput = 1,
    newinput = 1;
    
String code;

bool pair = false;

void setup() {
  Serial.begin(9600);
  pinMode(pinRead,INPUT_PULLUP);
}

void loop(){
  if(pair){
    newinput = digitalRead(6);
    if(previnput != newinput){
      previnput = newinput;
      if(previnput == 1){
        Serial.println("Coin Inserted");
      }
    }
  }else{
    if (Serial.available() > 0) {
      code = Serial.readString();
      code.trim();
      if(code == ""){}
      else if(code == "WhoAmI"){
        Serial.println("CoinTimer");
      }else if(code == "Worc"){
        Serial.println("9672");
        pair = true;
      }else{
        Serial.print("Invalid Code ");
        Serial.println(code);
        Serial.end();
      }
    }
  }
}


/*
void loop(){
  if(pair){
    newinput = digitalRead(6);
    if(previnput != newinput){
      previnput = newinput;
      if(previnput == 1){
        Serial.println("Coin Inserted");
      }
    }
  }else{
    if (Serial.available() > 0) {
      code = Serial.readString();
      code.trim();
      if(code == "Worc"){
        Serial.println("Code Accepted");
        pair = true;
      }else{
        Serial.print("Invalid Code ");
        Serial.println(code);
        Serial.end();
      }
    }
  }
}
*/
