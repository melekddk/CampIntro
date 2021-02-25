using System;
using System.Linq;

namespace MetotExtra
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add();
            //Add();
            //Add();
            //var result = Add2(2);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,9));
            Console.WriteLine(Add4(1,5,6,8,10));

            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Ekleme işlemi gerçekleşti.");
        }
        //Yeni sürümlerde metotlarda defaut değerleri tanımlanabilir.
        static int Add2(int number1, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        //Burada değer tip kullanıldığı için number1 ı tekrar yazdığımız zaman değeri yukaradaki gibi 20 olur.
        //Ancak referans değer olarak göndermek istediğimiz zaman başına ref değerini yazmamız gerekiyor.
        static int Add3( ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();

        }

    }
}
