using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {//satırları seçip ctl+k+c hepsini kod satırından çıkarır. geri almak için seçip ctrl+k+u yaparsın kısayolu
           
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };

            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);

            //kolleksiyon yazım syntaxı.
            List<string> isimler2 = new List<string>() { "ENgin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



            Console.WriteLine("Hello World!");
        }
    }
}
