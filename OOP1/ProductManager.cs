using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Ürün ile ilgili operasyonlar var içerisinde
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)  // (Class değişken)
        {
            product.ProductName = "Kamera";
        }
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
