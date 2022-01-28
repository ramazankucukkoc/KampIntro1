using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer()
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "DEMİROĞ",
                BirthYear=1983,
                IdentityNumber=12345
            }) ;
        }
    }
}
