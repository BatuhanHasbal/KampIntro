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
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1, int sayi2) // eğer başka bir yerde kullanacaksam bu sayıyı int ile yaparım. 
        {
            return sayi1 + sayi2;      
        }

        public void Topla2(int sayi1, int sayi2) // anlık yap bitir olacaksa void yapılır. 
        {
            Console.WriteLine(sayi1 + sayi2);
        }

    }
}
