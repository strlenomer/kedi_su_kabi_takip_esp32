// Kod https://github.com/strlenomer tarafindan yazilmistir.

#include <WiFi.h>
#include <WiFiUdp.h>


WiFiUDP server;

void setup() {
    WiFi.begin("AG_ADI", "AG_SİFRESİ"); // Ornek olarak WiFi.begin("Benimİnternetim_2.4GHz", "Benimsifrem");
    delay(1000);
    server.begin(4120); 
}
int check() {
    int veri = analogRead(34);
    return veri;
}
void loop() {
    int deger = check();
    server.beginPacket(IPAddress(255, 255, 255, 255), 4120);
    server.print(deger);
    server.endPacket();
    delay(1000); 
}
