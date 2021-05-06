using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "Yazılım Geliştirme Kampı";
            //string kurs2 = " Programlamaya Giriş";
            //string kurs3 = " JAVA Kursu";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı" , "Programlamaya Giriş" , "JAVA Kursu"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            } 
            Console.WriteLine("Sayfa sonu");

            //foreach = dizi temelli yapıları tek tek dönmeye yarar.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
