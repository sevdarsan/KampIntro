using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "tekin ";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "ahmet";
            kurs3.IzlenmeOrani = 33;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Console.WriteLine("sonraki");

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +":" + kurs.Egitmen);
            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }

    }


}
