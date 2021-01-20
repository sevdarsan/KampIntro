using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //MyListe de <> arasına string de int de herşey yazılabilir.
    //generic bir tane değer alıyorsa genelde T yazıloyor, başka birşey de yazılabilir. 
    //programcı daha sonrasında kullanırken hangisini sitiyorsa ona göre çalışır
    class MyList<T>
    {
        T[] items;
        //constructor deniyor. burada yapılan classı new lersen aşağısı otomatik çalışıyor.
        //ctor tab tab yapılırsa aşağısı gelir.
        public MyList()
        {
            items = new T[0];

        }
        public void Add(T item)
        {
            //geçici dizi yapıyoruz ki her eklemede eski referans numarasınu tutup yeni bilgileri ekleyerek ilerlesin.
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;


        }
    }
}
