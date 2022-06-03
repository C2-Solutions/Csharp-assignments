using System;
using System.Globalization;
using System.Collections.Generic;

#pragma warning disable CS8632
namespace PetShop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our petshop!");

            // Defining animals and sellables to loop over later.
            List<Animal?> animals = new()
            {
                new Dog(),
                new Bird(),
                new Fish(),
                // new Blåhaj()
            };


            // All the printing
            Console.WriteLine("We have the following animals on display:");
            PrintSpecies(animals);

            Console.WriteLine("\nIf you listen closely, you can even hear them!");
            PrintSounds(animals);

            Console.WriteLine("\nWe also sell the following toys and treats:");
        }

        // Main functions
        public static void PrintSpecies(List<Animal?> animals)
        {
            foreach (Animal animal in animals) {
                if (animal is not null) Console.WriteLine($"- {animal.GetSpecies()}");
            }
        }

        public static void PrintSounds(List<Animal?> animals)
        // Prints the sound of every animal
        {
            foreach (Animal animal in animals) {  if (animal is not null) animal.MakeSound(); }
        }

        // Helper functions
        public static string CurrencyToString(double value)
        {
            return value.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
