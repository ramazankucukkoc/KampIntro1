﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EEESSSSEEEECCCEEEEEZZZZZ");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin DEMİROĞ";
            kurs1.IzlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;
            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+
            //kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {
            kurs1,kurs2,kurs3 };
            foreach (var  kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + 
                    kurs.Egitmen);
            }
            
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    class Product
    {

    }
}
