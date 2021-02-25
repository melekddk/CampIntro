using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean = value types
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " + sayi1);

            //arrays, class,interface...= reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar 1[0] :" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Melek";

            person2 = person1;
            person1.FirstName = "Ayda";

            //Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Anıl";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();
            employee.FirstName = "Yada";

            Person person3 = customer;
            customer.FirstName = "Ayaz";


            //person3 e bir Customer boxing yap diyoruz. Bir nevi kutu haline getiriyoruz.
            //Burada atanabilenlerden istediğimiz bir tipi atayabiliyoruz. Biz burda Customer class ı atadık
            // Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

            //Biz burada ne verirsek verelim kod çalışacak çünkü PersonManager da base class ı tanımladığımız için soru olmuyor.
            //Person ebeveyn den  türeme durumu va burada.

            //Console.WriteLine(person3.FirstName);
             
        }
    }

    //Base class : Person = Person ı bir ebeveyn olarak düşünürsek Customer ve Employee ondan miras alıyor.
    //Onun çocukları olarak düşünülebilir. Bu durumda adres ataması olabiliyor. 
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer: Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person //Employee = çalışan, işçi
    {
        public int EmployeeNumber { get; set; }
    }


    class PersonManager
    {
        public void Add(Person person) //Bu durum bizim aynı kodu farklı nesneler için kullanmamıza olanak tanıyor. 
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
