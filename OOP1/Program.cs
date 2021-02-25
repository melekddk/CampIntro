using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //101.Bellekteki lokasyon adresini yollama işlemi oluyor.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //Farklı yazım şekilleri de oluyor.Bu şekilde entity oluşturulabiliyor.
            Product product2 = new Product { Id = 2, CategoryId = 5, 
            UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            
        //PascalCase = Kelimelerin ilk harfi büyük yazılır.Class anlamına geliyor.
        //camelCase =İlk kelimenin ilk harfi küçük sonra gelen keimenin ilk harfi büyük yazılıyor.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


        }
    }
}
 