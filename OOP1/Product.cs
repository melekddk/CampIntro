using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity = Varlık gibi isimler veririz. Bu tarz classlarda sadece özellik olur
    {//snippet= prop yazdıktan sonra altında 3 nokta şeklinde çıkması
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//Ürün birim fiyatı
        public int CategoryId { get; set; }//Referans anahtar. 2.cil anahtar
        public int UnitInStock { get; set; } //Stok Adedi
    }
}
