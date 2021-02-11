using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention = isimlendirme kuralı
        //Eğer bir yerde normal parantez görülürse orada bir metot çalışıyor demektir.
        //Fonksiyon metot aynı şeye çıkıyor.
        //neyi eklemek istediğimizi metot kısmına vermek lazım buna parametre deniliyor.
        public void Ekle(Urun urun)//Urun =tip urun= aşağıda kullanılan
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}
