# kedi_su_kabi_takip_esp32

(!) Esp32 tarafında C++ ile yazılmış basit bir udp sistemi var kurulumda gerekenler:
(1) Su sensörünün + kısmı VIN veya 3.3V pinine
(2) Su sensörünün S kısmı Esp32 nin 34 numaralı pinine
(3) Su sensörünün - kısmı GND pinine
(4) esp32kod.ino (Esp Kodunun) içinde ki modem ssid ve modem password kısımlarına kendi
modem adı ve şifrenizi yazıp derleyiniz ve kodu esp32 ye atınız elektrik verdiğinizde otomatik bağlanıp çalışmaya başlayacaktır

(#) Android tarafı C# .NET MAUI ile geliştirilmiştir isterseniz apkindir.txt de hazır apk dosyası vardır isterseniz de repoda ki uygulamanın kaynak kodlarını (MainPage.xaml MainPage.xaml.cs MauiProgram.cs App.cs) alıp düzenleyip derleyebilirsiniz

(#) Sistemin çalışması şöyle internete bağlanan esp32 saniyede bir sensörden çektiği su verisini
modemin broadcast ipsine (255.255.255.255) internete bağlı olan tüm cihazların 4120 numaralı portuna udp olarak gönderir uygulama ise açıldığında sürekli 4120 numaralı portu dinler ve veriyi alır az mı iyi mi orta mı olduğuna bakar ekrana yazar
