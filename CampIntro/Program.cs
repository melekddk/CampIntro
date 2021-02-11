using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //String= Sayısal ve metinsel verileri tutuyor.
            //Type safety= Tip güvenliği
            //Metinsel olayları tek tırnak ile olmuyor.
            // Do not repeat yourself = Kendini tekrarlama 
            //kategoriEtiketi = Değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.65;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
