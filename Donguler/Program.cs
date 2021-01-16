using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler-arrays

            string[] kurslar = new string[] {"kurs1","kurs2","kurs3","kurs4"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("sayfa sonu-footer");
            //foreach dizilere uygulanır.dizileri tek tek dolaşır.

            foreach (string kurs in kurslar)
            {
                                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu-footer");


        }
    }
}
