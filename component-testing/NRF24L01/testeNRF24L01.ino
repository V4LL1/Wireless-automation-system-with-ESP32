#include <SPI.h>
#include <RF24.h>

// Defina os pinos CE, CSN e IRQ do NRF24L01
#define CE_PIN 12
#define CSN_PIN 13
#define IRQ_PIN 26

RF24 radio(CE_PIN, CSN_PIN); // Inicializa o objeto RF24

// Endereço de destino para onde a mensagem será enviada
const byte enderecoDestino[6] = "00001";

void setup() {
  Serial.begin(9600);
  delay(1000);

  // Configuração dos pinos SPI
  SPI.begin(32, 33, 25, CSN_PIN); // Pinos SCK, MOSI, MISO e CSN

  // Inicializa o rádio NRF24L01
  if (!radio.begin()) {
    Serial.println("Falha ao inicializar o rádio NRF24L01.");
    Serial.println("Verifique as conexões e alimentação.");
    while (1); // Fica preso em um loop infinito
  } else {
    Serial.println("Rádio NRF24L01 inicializado com sucesso!");
  }

  // Configura o endereço de escrita
  radio.openWritingPipe(enderecoDestino);
  
  // Define o nível de potência do rádio
  radio.setPALevel(RF24_PA_LOW);

  // Configura o rádio para transmitir (não receber)
  radio.stopListening();

  // Configura o pino IRQ como entrada e ativa as interrupções
  pinMode(IRQ_PIN, INPUT);
}

void loop() {
  // Cria uma mensagem para enviar
  const char *mensagem = "Teste NRF24L01";
  
  // Envia a mensagem e verifica o status de envio
  if (radio.write(mensagem, strlen(mensagem) + 1)) {
    Serial.println("Mensagem enviada com sucesso!");
  } else {
    Serial.println("Falha ao enviar a mensagem. Verifique a conexão NRF24L01.");
  }

  delay(1000); // Aguarda um segundo antes de enviar a próxima mensagem
}
