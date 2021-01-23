using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //krediyerlerine "IKrediManager" yazsaydık aynı sonuç olacaktı. class lar gibi
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKresiManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKresiManager, fileLoggerService);// kısa yolu ", new DataBaseLoggerService" direk yazılabilir.



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKresiManager,konutKrediManager };


           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.WriteLine("--------- --------");
            Console.WriteLine("Hello World!");
        }
    }
}
