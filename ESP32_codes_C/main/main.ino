#include "DHT.h"

#define DHTPIN 23
#define DHTTYPE DHT22

#define RELAY1 18
#define RELAY2 19
#define RELAY3 26
#define RELAY4 27

// Motor de passo (28BYJ-48 com ULN2003)
#define IN1 26
#define IN2 27
#define IN3 25
#define IN4 33

DHT dht(DHTPIN, DHTTYPE);

unsigned long relayTimers[4] = {0, 0, 0, 0};
bool relaysActive[4] = {false, false, false, false};
const int relayPins[4] = {RELAY1, RELAY2, RELAY3, RELAY4};

void setup() {
  Serial.begin(9600);
  dht.begin();

  // Relés
  for (int i = 0; i < 4; i++) {
    pinMode(relayPins[i], OUTPUT);
    digitalWrite(relayPins[i], HIGH); // relé desligado (ativo em LOW)
  }

  // Motor
  pinMode(IN1, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(IN3, OUTPUT);
  pinMode(IN4, OUTPUT);
  desligaMotor();
}

void loop() {
  // Leitura do sensor
  float t = dht.readTemperature();
  if (!isnan(t)) {
    Serial.print("TEMP:");
    Serial.println(t);
  }

  // Leitura de comandos seriais
  if (Serial.available()) {
    String cmd = Serial.readStringUntil('\n');
    cmd.trim();

    // Comandos de relé
    for (int i = 1; i <= 4; i++) {
      if (cmd.startsWith("ON" + String(i) + ":")) {
        int dur = cmd.substring(4).toInt(); // tempo em segundos
        digitalWrite(relayPins[i - 1], LOW); // ativa o relé
        relaysActive[i - 1] = true;
        relayTimers[i - 1] = millis() + dur * 1000;
      }
    }

    // Comando de motor
    if (cmd.startsWith("MOTOR:")) {
      int dur = cmd.substring(6).toInt(); // tempo em segundos
      if (dur > 0) {
        Serial.println("Motor ligado por " + String(dur) + " segundos");
        acionarMotorPorTempo(dur);
        Serial.println("Motor desligado");
      }
    }
  }

  // Controle de tempo dos relés
  for (int i = 0; i < 4; i++) {
    if (relaysActive[i] && millis() > relayTimers[i]) {
      digitalWrite(relayPins[i], HIGH); // desliga o relé
      relaysActive[i] = false;
    }
  }

  delay(2000);
}

// ----------- MOTOR DE PASSO -----------
void desligaMotor() {
  digitalWrite(IN1, LOW);
  digitalWrite(IN2, LOW);
  digitalWrite(IN3, LOW);
  digitalWrite(IN4, LOW);
}

void passoMotor(int passo) {
  switch (passo % 4) {
    case 0:
      digitalWrite(IN1, HIGH); digitalWrite(IN2, LOW); digitalWrite(IN3, LOW); digitalWrite(IN4, LOW);
      break;
    case 1:
      digitalWrite(IN1, LOW); digitalWrite(IN2, HIGH); digitalWrite(IN3, LOW); digitalWrite(IN4, LOW);
      break;
    case 2:
      digitalWrite(IN1, LOW); digitalWrite(IN2, LOW); digitalWrite(IN3, HIGH); digitalWrite(IN4, LOW);
      break;
    case 3:
      digitalWrite(IN1, LOW); digitalWrite(IN2, LOW); digitalWrite(IN3, LOW); digitalWrite(IN4, HIGH);
      break;
  }
}

void acionarMotorPorTempo(int segundos) {
  int passosPorSegundo = 512; // pode ajustar a velocidade
  int totalPassos = passosPorSegundo * segundos;

  for (int i = 0; i < totalPassos; i++) {
    passoMotor(i);
    delay(2); // controle de velocidade
  }

  desligaMotor();
}
