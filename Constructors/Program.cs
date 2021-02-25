using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Melek", LastName = "Dedik", City ="İstanbul"};

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Zeynel";
            customer3.LastName = "Ayan";
            customer3.City = "İzmir";
            
            Customer customer2 = new Customer(2,"Ayla","Aymaz","Trabzon");
            //Burda ilk okumuyor çünkü aşağıda constructor parametrelerindekilerin hepsi yok.
            Console.WriteLine(customer2.FirstName); 

        }

        
    }

    class Customer
    {
        //Bir tane constructor yazmamız için ctor yazıp tab 2 kere basıldığı zaman bize constructor oluşturu
        //Böyle olan yapılar constructor 
        //Constructorlar da da overloading olayı var.
        public Customer()
        {

        }
        
        //Default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;  //Burda değerlerimizi set ettik.
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
