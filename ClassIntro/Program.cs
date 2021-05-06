using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();   //class değişkeni tanımlama - Alttakide değer atamaları 
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();   //class değişkeni tanımlama - Alttakide değer atamaları 
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Batuhan HASBAL";
            kurs2.IzlenmeOrani = 99;

            Kurs kurs3 = new Kurs();   //class değişkeni tanımlama - Alttakide değer atamaları 
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ecrin HASBAL";
            kurs3.IzlenmeOrani = 1;

           //Console.WriteLine("Kurs Adı :" + kurs1.KursAdi + " Eğitmen : " + kurs1.Egitmen + " İzlenme Oranı : " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı :" + kurs.KursAdi);
                Console.WriteLine("Eğitmen :" + kurs.Egitmen);
                Console.WriteLine("İzlenme Oranı :" + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
