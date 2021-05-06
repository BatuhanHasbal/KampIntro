using System;
// Metot : tekrar tekrar kullanılabilirliği sağlayan ortam (Don't repeat yourself)
// Clean Code 
// Herşey class lardan oluşur
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //class tanımlama 
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokDurumu = 10;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokDurumu = 20;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //in urunler => ürünler dizisinin her elemanını tek tek gez
            //urun => o anki elemana takma isim her hangi isim verilebilir.
            //Urun => veri tipi   type-safe -- tip güvenli - var olursada farketmez 

            foreach (Urun urun in urunler) 
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("-------------METOTLAR-----------------");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);   //methot çağırma
            sepetManager.Ekle(urun2);

            //encapsulation :
           
        }
    }
}
