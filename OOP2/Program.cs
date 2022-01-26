using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo =" 12345";
            musteri1.Adi = "Ramazan";
            musteri1.Soyadi = "Küçükkoç";
            musteri1.TcNo = "38191793875";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Hacallar A.Ş";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            //musteri3 GercekMusteri referans numarasını tutuyor..
            Musteri musteri4 = new TuzelMusteri();
            //musteri4 TuzelMusteri referans numarasını tutuyor...
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);





        }
    }
}
