using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //<string,Product, int.. vb.>Hangi tür istiyorsak onu yazabiliriz.
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Melek");

            Console.WriteLine(isimler.Length);

            isimler.Add("Ayla");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
