using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Computer";
            product1.StokAdedi = 2;
            product1.Price = 5000;
            product1.Brand = "ASUS";

            Product product2 = new Product();
            product2.ProductName = "Computer";
            product2.StokAdedi = 5;
            product2.Price = 7000;
            product2.Brand = "LENOVO";

            Product product3 = new Product();
            product3.ProductName = "Phone";
            product3.StokAdedi = 5;
            product3.Price = 2000;
            product3.Brand = "SAMSUNG";

            Console.WriteLine("Hello World!");
            Product[] products = new Product[]
            {
            product1,product2,product3
            };
            Console.WriteLine("Foreach Döngüsü----------------------");
            foreach (var urun in products)
            {
                Console.WriteLine(urun.ProductName+ ":"+urun.StokAdedi+ ":"+
                    urun.Price + ":"+urun.Brand);
            }
            Console.WriteLine("For Döngüsü----------------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName +":"+products[i].StokAdedi+ ":"+
                    products[i].Price +":"+products[i].Brand);
            }
            int j = 0;
            Console.WriteLine("While Döngüsü------------------------");
            while (j<products.Length)
            {
                
                Console.WriteLine(products[j].ProductName + ":" + products[j].StokAdedi + ":" +
                   products[j].Price + ":" + products[j].Brand);
                j++;
            }
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public int StokAdedi { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
    }
}
