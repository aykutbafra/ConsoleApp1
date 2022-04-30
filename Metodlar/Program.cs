//Program.cs C# dosyası olduğunu anlıyoruz
using System;

namespace Metodlar
{

    class Program
    {

        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80 ;
            urun2.Aciklama = "diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type - safe -- tip güvenliği
            Console.WriteLine("Ürünler");

            foreach (Urun urun in urunler)
            {
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------Metotlar----------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //sepetManagerden ekle yi çağırdık
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yesil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }


    }
}