#include "DHT.h"

#define DHTPIN 4
#define DHTTYPE DHT22

#define RELAY1 16
#define RELAY2 17
#define RELAY3 18
#define RELAY4 19

DHT dht(DHTPIN, DHTTYPE);

unsigned long relayTimers[4] = {0, 0, 0, 0};
bool relaysActive[4] = {false, false, false, false};
const int relayPins[4] = {RELAY1, RELAY2, RELAY3, RELAY4};

void setup() {
  Serial.begin(9600);
  dht.begin();

  for (int i = 0; i < 4; i++) {
    pinMode(relayPins[i], OUTPUT);
    digitalWrite(relayPins[i], HIGH);
  }
}

void loop() {
  float t = dht.readTemperature();
  if (!isnan(t)) {
    Serial.print("TEMP:");
    Serial.println(t);
  }

  if (Serial.available()) {
    String cmd = Serial.readStringUntil('\n');
    cmd.trim();

    for (int i = 1; i <= 4; i++) {
      if (cmd.startsWith("ON" + String(i) + ":")) {
        int dur = cmd.substring(4).toInt();
        digitalWrite(relayPins[i - 1], LOW);
        relaysActive[i - 1] = true;
        relayTimers[i - 1] = millis() + dur * 1000;
      }
    }
  }

  for (int i = 0; i < 4; i++) {
    if (relaysActive[i] && millis() > relayTimers[i]) {
      digitalWrite(relayPins[i], HIGH);
      relaysActive[i] = false;
    }
  }

  delay(2000);
}
