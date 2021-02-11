using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler = Bir şeyi tekrar etmek için kullanılan yapılardır.
            //i = sayaç döngünün yaşam döngüsünü bununla kontrol ediyoruz. i+=2


            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
            "Programlamaya Başlangıç için Temel Kurs",
              "Java", "Python"};

            //Length = kursların eleman sayısını veriyor. 4 tane var burada
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti.");

            //String = Baş harfi büyük olan class a karşılık
            //foreach= Dizi temelli yapıları tek tek dönmeye yarıyor.
            //kurs= alias demek değişebiliyor onun yerine başka isimde verilebilir.
            //kurs= kurslarda ki herbir elemanı dolaşmak için verdiğimiz takma isim

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
