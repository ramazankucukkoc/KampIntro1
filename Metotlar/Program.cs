using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Muz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Antalya Muzu";

            Urun[] urunler = new Urun[] {
           urun1,urun2
            };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi );
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------");
            }

             Console.WriteLine("----------Metotlar-------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            


        }
    }
}
