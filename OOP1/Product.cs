using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //primarykey olan yer aslında sql de
        public int CategoryId { get; set; }  //foreignkey olan yer. sql de
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitStock { get; set; }

        




    }

}
