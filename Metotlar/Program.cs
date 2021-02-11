using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            //class dan bir değişken tanımlanacağı zaman onun sağ tarafında bu şekilde bir tanımlama yapılması gerekli.
            //Üründen birden fazla oluşturulabilir.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 100;
            urun2.Aciklama = "Diyarbakır karpuzu";

            //Nasıl string array i oluşturulabiliyorsa aynı şekilde urun array i de oluşturulur.
            //Veriler bir veri kaynağından gelir. Bu bazen ip olabilir bazende veritabanı olabilir. Duruma göre değişiyor.
            Urun[] urunler = new Urun[] { urun1, urun2 };
            //urunler= urunler dizisini tek tek gez demek
            //urun = o an ki dönen ürünü tutuyor.
            //var yerine yazılan Urun ise veritipidir. C#, Java gibi programlama dilleri tip güvenlidir.
            //type safe = tip güvenliği 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("-------Metotlar---------");

            //instance= class örneği
            //Encapsulation= Kapsülleme demek. Ayrı ayrı yazacağın bir yapıyı düzenli bir şekilde yazıyorsun.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//metotu çağırmak istediğimizde
            sepetManager.Ekle(urun2);



            sepetManager.Ekle2("Armut", "Yeşil armut", 15, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 15, 20);





            //Class ların 2 temel kullanımı var. 1. Foreach da ki gibi özellik tutuyorlar.
            //Classların 2. kullanımı= class ın sonunda manager, service, dal, dataaccess, controller gibi ifadeler varsa bunlar bir operasyon tutuyor demek.
            //Metot= Sepete ekleme,listeleme gibi işlemleri bu yöntem ile yaparız.
            //Müşteri ile ilgili işlemler, ürün ile ilgili işlemler gibi kısımları metotlar ile yaparız.

        }
    }
}
