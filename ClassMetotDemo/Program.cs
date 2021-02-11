using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Ayla";
            musteri1.MusteriSoyad = "Solmaz";
            musteri1.EPosta = "ayla12_solmaz@gmail.com";
            musteri1.MusteriSifre = "8925356";
            musteri1.IslemTuru = "Hesap İşlemleri";
            musteri1.Aciklama = "Para Çekimi";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Tarık";
            musteri2.MusteriSoyad = "Aymaz";
            musteri2.EPosta = "tarikaymaz@hotmail.com";
            musteri2.MusteriSifre = "000025868";
            musteri2.IslemTuru = "Döviz İşlemleri";
            musteri2.Aciklama = "Teknolojik alet alımı";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAd = "Cengiz";
            musteri3.MusteriSoyad = "Cindoruk";
            musteri3.EPosta = "cindorukcengizz@outlook.com";
            musteri3.MusteriSifre = "8895620256";
            musteri3.IslemTuru = "Havale";
            musteri3.Aciklama = "Heykel alımı";


         


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri1);
            musteriManager.Sil(musteri2);
        }
    }
}
