using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProjects
{
    class Program
    {
        static void Main(string[] args)
         {   
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                 new Category{CategoryId=2,CategoryName="Telefon"}
            };
       
            List<Product> products = new List<Product>
            {
               new Product{ ProductId=1,CategoryId=1,ProductName="Acer Laptop" ,QuantityPerUnity="12 GB Ram",UnitPrice=10000,UnitsInStock=5},
               new Product{ ProductId=2,CategoryId=1,ProductName="Lenovo Laptop" ,QuantityPerUnity="16 GB Ram",UnitPrice=18000,UnitsInStock=3},
               new Product{ ProductId=3,CategoryId=1,ProductName="Hp Laptop" ,QuantityPerUnity="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
               new Product{ ProductId=4,CategoryId=2,ProductName="Samsung Telefon" ,QuantityPerUnity="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
               new Product{ ProductId=5,CategoryId=2,ProductName="Apple Telefon" ,QuantityPerUnity="4 GB Ram",UnitPrice=8000,UnitsInStock=0}
            };
            // Console.WriteLine("Linq-----------------");
            //Any(products);
            //FindAll(products);
            //Test(products);
            //Find(products);
            // OrderBy(products);
            //  ClassicLinqTest(products);
            var result = from P in products
                         join c in categories on P.CategoryId equals c.CategoryId
                         where P.UnitPrice>=8000
                         orderby P.UnitPrice descending
                         select new ProductDto {ProductId=P.ProductId, CategoryName = c.CategoryName,ProductName=P.ProductName,UnitPrice=P.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} ",productDto.ProductName,productDto.CategoryName,productDto.UnitPrice,productDto.ProductId);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from P in products
                         where P.UnitPrice > 5000
                         orderby P.UnitPrice descending, P.ProductName ascending
                         select new ProductDto { ProductId = P.ProductId, ProductName = P.ProductName, UnitPrice = P.UnitPrice };

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void OrderBy(List<Product> products)
        {
            //Bunların hepsi linq'dır OrderBy sıralı şekilde geliyor OrderBy Azalan sırada getiriyor
            //OrderByDescending en yüksek degerden başlayıp azalarak getiriyor 
            // önce diğer kodları okuyup sıraladı sonra ThenByDescending kurala göre sıralama yapıyor..
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitsInStock).ThenByDescending(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static bool Any(List<Product> products)
        {
            //Any metodu Linq de listedeki elemanın Olup Olmamasına Bakıyor..
            return products.Any(p => p.ProductName == "Acer Latop");
        }

        private static void Find(List<Product> products)
        {
            //Find metodu Linq de listedeki eleamanı bulıyor
            var result1 = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result1.ProductName);
        }

        private static void FindAll(List<Product> products)
        {
            var SONUC = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(SONUC);
        }

        private static void Test(List<Product> products)
        {
            var result1 = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            //Console.WriteLine(result);
            foreach (var pro in result1)
            {
                Console.WriteLine(pro.ProductName);
            }
        }
    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
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
