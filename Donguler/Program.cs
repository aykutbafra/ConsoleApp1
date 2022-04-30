using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetistirme Kampı";
            string kurs2 = "Programa Baslangıc Icın temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampı",
                "Programa Baslangıc Icın temel kurs",
                "Java", "Python", "C#" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //kursları dolaş
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            } 

            Console.WriteLine( "Sayfa Sonu - footer");
        }
    }
}