using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + ", " + "Tebrikler sisteme kaydınız gerçekleşti.");

            Console.WriteLine("   ");



        }


        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Sitemdeki Müşteri :" + musteri.MusteriAd + " " + musteri.MusteriSoyad);
            Console.WriteLine("E-postası :" + musteri.EPosta);
            Console.WriteLine("İşlem Türü :" + musteri.IslemTuru);
            Console.WriteLine("Açıklama :" + musteri.Aciklama);

            Console.WriteLine("   ");


        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + ", " + "kişisinin silme işlemi gerçekleşti. ");
        }
    }
}
