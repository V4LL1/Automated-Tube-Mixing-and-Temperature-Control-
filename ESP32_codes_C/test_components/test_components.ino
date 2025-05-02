#include "DHT.h"

#define DHTPIN 4          // Pino de dados do DHT22
#define DHTTYPE DHT22     // Tipo do sensor

// Pinos dos relés
#define RELAY1 16
#define RELAY2 17
#define RELAY3 18
#define RELAY4 19

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(115200);
  dht.begin();

  // Configura os pinos dos relés como saída
  pinMode(RELAY1, OUTPUT);
  pinMode(RELAY2, OUTPUT);
  pinMode(RELAY3, OUTPUT);
  pinMode(RELAY4, OUTPUT);

  // Desliga todos os relés no início (nível ALTO se acionamento for por nível BAIXO)
  digitalWrite(RELAY1, HIGH);
  digitalWrite(RELAY2, HIGH);
  digitalWrite(RELAY3, HIGH);
  digitalWrite(RELAY4, HIGH);
}

void loop() {
  float temp = dht.readTemperature();
  float hum = dht.readHumidity();

  if (isnan(temp) || isnan(hum)) {
    Serial.println("Falha ao ler do sensor DHT!");
    return;
  }

  Serial.print("Temperatura: ");
  Serial.print(temp);
  Serial.print(" °C\tUmidade: ");
  Serial.print(hum);
  Serial.println(" %");

  // Lógica para ativar relés com base na temperatura
  if (temp > 30) {
    digitalWrite(RELAY1, LOW);  // Liga relé 1
  } else {
    digitalWrite(RELAY1, HIGH); // Desliga relé 1
  }

  if (temp > 35) {
    digitalWrite(RELAY2, LOW);  // Liga relé 2
  } else {
    digitalWrite(RELAY2, HIGH); // Desliga relé 2
  }

  delay(2000); // Espera 2 segundos antes da próxima leitura
}
