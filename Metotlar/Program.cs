using System;

namespace Metotlar
{
    class Program
    {
        //metotlar tekrar tekrar kullanılan kodlardır. başka projelerde de kullanılabilecek kod yazmalı. do not repeat yourself-clean code
        //best practices demek en iyi uygulama teknikleridir.

        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elmasi";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amsya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type safe- tip güvenli. çalışacağım veri tipini bilmek isterim demek.

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("------şevdar. Metotlar-------");

            //instance - örnek oluşturma
            //encapsulation-ekle urun kısmı olan metotlarda yapılanlar.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "olgun", 12,10);
            sepetManager.Ekle2("elma", "yeşil", 7,8);
            sepetManager.Ekle2("karpuz", "kelek", 20,55);

            Console.WriteLine("Hello World!");
        }
    }
}
