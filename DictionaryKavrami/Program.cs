using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1)Dictionary sınıfı içinde sizin belirleyeceğiniz bir key e uygun olarak değer saklar
             *  zorunluluğu vardır.
             *  2) Key türünü belirlemeniz şart (int, string, bool, vb.)

             */
            Dictionary<string, int> AdYas = new Dictionary<string, int>();

            //veri ekleme
            AdYas.Add("Ali", 23);
            AdYas.Add("Leman", 21);
            AdYas.Add("Ayşe", 30);

            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }

            //Değer sayma özelliği vardır.

            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman sayısı : " + eleman);


            //Silme işlemi

            AdYas.Remove("Leman");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();
        
        
        }

    }
}
