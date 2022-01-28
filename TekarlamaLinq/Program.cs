using System;
using System.Collections.Generic;
using System.Linq;
namespace TekarlamaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products=new List<Product>
            {
                new Product { ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=10},
                new Product { ProductId=1,CategoryId=2,ProductName="Mouse",UnitPrice=70},
                new Product { ProductId=1,CategoryId=1,ProductName="Kalem",UnitPrice=5},
                new Product { ProductId=1,CategoryId=2,ProductName="Samsun Telefon",UnitPrice=1000}
            };
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Ev Eşyası"},
                new Category{CategoryId=2,CategoryName="Teknoloji Eşyası"},
            };
            var result = from P in products
                         join C in categories on P.CategoryId equals C.CategoryId
                         where P.UnitPrice > 65
                         select new Product
                         {
                             ProductName = P.ProductName,
                             CategoryId = C.CategoryId,
                             ProductId = P.ProductId,
                             UnitPrice = P.UnitPrice
                         };
            foreach (var products1 in result)
            {
                Console.WriteLine(products1.ProductName +"---" +products1.UnitPrice);
            }
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }

    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
