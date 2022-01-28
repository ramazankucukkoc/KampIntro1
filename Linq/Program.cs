using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
               new Product{ ProductId=1,CategoryId=1,ProductName="Acer Laptop" ,QuantityPerUnity="12 GB Ram",UnitPrice=10000,UnitsInStock=5},
               new Product{ ProductId=2,CategoryId=1,ProductName="Lenovo Laptop" ,QuantityPerUnity="16 GB Ram",UnitPrice=8000,UnitsInStock=3},
               new Product{ ProductId=3,CategoryId=1,ProductName="Hp Laptop" ,QuantityPerUnity="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
               new Product{ ProductId=4,CategoryId=2,ProductName="Samsung Telefon" ,QuantityPerUnity="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
               new Product{ ProductId=5,CategoryId=2,ProductName="Apple Telefon" ,QuantityPerUnity="4 GB Ram",UnitPrice=8000,UnitsInStock=0}           
            };
            Console.WriteLine("Algoritmik---------- ");
            foreach (var product in products)
            {
                if (product.UnitPrice>5000&&product.UnitsInStock>3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq-----------------");

            var result = products.Where(p => p.UnitPrice>5000 && p.UnitsInStock>3);
            //Console.WriteLine(result);
            foreach (var pro in result)
            {
                Console.WriteLine(pro.ProductName);
            }
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnity { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
