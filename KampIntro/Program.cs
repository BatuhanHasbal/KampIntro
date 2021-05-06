using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            //if (sistemeGirisYapmisMi == true) 
            //{
            //    Console.WriteLine("Giriş yapmış");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yapmamış ");
            //}

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("↑");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("↓");
            }
            else
            {
                Console.WriteLine("=");
            }
            // Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
