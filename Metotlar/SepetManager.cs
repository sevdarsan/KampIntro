using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming conversion- doğru adlandırma
        //metot oluşturma, kodu tekrar tekrar kullanmayı ve heryerde değişiklik yapmay kolaylaştırır
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {

            Console.WriteLine("bu da sepete eklendi: " + urunAdi);

        }


    }
}
