using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); //30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //999s

            // int , decimal , float , dobule , bool vb.  = değer tiptir. -stack- tipi atarsın
            // array , class , interface = referans tiptir. -heap- adresi atarsın
            // bellekte stack ve heap 2 alan vardır. 
            // stack kısmında değerleri atarsın o değeri alır ve işi orada biter.
            // heap kısmında ise referans adresine atanır.
            // new heapte yeni bir yer/adres oluşturur.
        }
    }
}
