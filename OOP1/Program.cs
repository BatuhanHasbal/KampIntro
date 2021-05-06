using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ürün Ekleme 1.Yöntem
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;  //mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500 ;
            product1.UnitsInStock = 3;

            // Ürün Ekleme 2.Yöntem
            Product product2 = new Product {Id=2 , CategoryId=5, UnitsInStock=5, ProductName ="Kalem" , UnitPrice=35 };

            //string isim = "Batuhan" ; ==>  BENZER İŞLER  class değişken ismi = new class();
            //referans tipin heap kısmında oluşması için new yapıyoruz.
            //stack = heap
            //PascalCase    camelCase
            ProductManager productManager = new ProductManager();  //instance create class oluşturma
            productManager.Add(product1);  //ekleyecem ama ne ekleyeceğim ? bu yüzden parametre ekliyoruz.
            Console.WriteLine(product1.ProductName);  // Answer = Kamera

            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi); // Answer = 100

            

        }
    }
}
