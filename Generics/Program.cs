using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
             sehirler.Add("Ankara");
             sehirler.Add("Ankara");
             sehirler.Add("Ankara");
             sehirler.Add("Ankara");
             sehirler.Add("Ankara");
             sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
           
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count);//Count işlemini aşağıda yaptığımızdan burada da kullanabiliyoruz.
            

        }
    }

    class MyList<T>//Generic bir class
    {
        T[] _array;
        T[] _tempArray; //Geçici array
        

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array; //tempArray de array in referansını tutuyor.
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;//Bu şekilde en son ne eklenmisse onu eklemiş oluyoruz.
        }

        public int Count //Count değerini döndürme işlemi
        {
            get { return _array.Length; }
           
        }

    }
}
