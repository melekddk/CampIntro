using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();

            //veri ekleme
            AdYas.Add("Ali", 23);
            AdYas.Add("Leman", 21);
            AdYas.Add("Ayşe", 30);

            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }

        }
    }

}
