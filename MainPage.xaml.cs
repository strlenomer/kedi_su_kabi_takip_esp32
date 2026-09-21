using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MySolution;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Dinle();
                    
    }
    private async void Dinle() {
        var soket = new UdpClient(4120);
        while (true) {
            var veri = await soket.ReceiveAsync();
            string decoded_veri = Encoding.UTF8.GetString(veri.Buffer);
            int deger = int.Parse(decoded_veri);
            if (deger < 800) {
                output.Text = $"Kedinin suyu bitti / çok az 🐈 Su seviyesi: {deger}";
                
            } else if (deger < 1800)  {
                output.Text = $"Kedinin suyu azaldı (orta) 🐈 Su seviyesi: {deger}";
            } else {
                output.Text = $"Kedinin su seviyesi yeterli 🐈 (iyi) Su seviyesi: {deger}";
            }
            
        }
        
    }
}   