using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Melek";
            int yas = 23;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            //Obje
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 88;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Yazılıma Giriş";
            kurs4.Egitmen = "Melek DEDİK";
            kurs4.IzlenmeOrani = 98;

            //Console.WriteLine(kurs1.KursAdi +" :" + kurs1.Egitmen);
            //Önceden string tutuluyordu şimdi kurs objesi tutuluyor.
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

            }
        }
    }
    //class = obje demektir
    class Kurs
    {
        //Property = özellik 
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
