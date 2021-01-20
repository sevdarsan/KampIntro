using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitStock = 3;
            //bu şekilde oluşturulabilir. ayrıca aşağıdaki gibide yapılabilir.kısa olarak.

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitStock = 5, ProductName = "Kalem", UnitPrice = 35 };


            //PascalCase=claslar //camelCase=değişkenismi genelde bu şekilde
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);




            Console.WriteLine("Hello World!");
        }
    }
}
