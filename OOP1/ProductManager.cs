using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {//void, belirtilen metotlarda işlem sonucunda ne olduğuna ihtiyacın olmadığında kullanılyor.
        //eğer işlem sonucunda ortaya çıkan sonucu kullanmak istiyorsan void kullanamazsın. 
        //onun için int,string vs.. kullanıp return kullanılır.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");    
            
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

    }
}
