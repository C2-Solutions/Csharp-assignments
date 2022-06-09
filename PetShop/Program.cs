using System;
using System.Collections.Generic;

namespace PetShop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our petshop!");

            // Defining animals and sellables to loop over later.
            List<Animal> animals = new()
            {
                new Dog(),
                new Bird(),
                new Fish(),
                // new Blåhaj()
            };

            List<ISellable> sellables = new()
            {
                new Toys(),
                new Food()
            };

            // Retrieving certain values to be printed later.
            // Should the scope expand, it'll be a good idea to rework this.
            double totalPrice = CombinedPriceAnimals(animals) + CombinedPriceSellables(sellables);
            double sellableWeight = CombinedWeightSellables(sellables);

            // All the printing
            Console.WriteLine("\nWe have the following animals on display:");
            AnimalPrintSpecies(animals);

            Console.WriteLine("\nIf you listen closely, you can even hear them!");
            AnimalPrintSounds(animals);

            Console.WriteLine("\nWe also sell the following toys and treats:");
            SellablesPrintNames(sellables);

            Console.WriteLine($"\nIf you'd like to buy one of each, it will cost you exactly {totalPrice} EUR,\n"
                              + $"and if you'd like to know how much one of each item weights, it's {sellableWeight}kg.");
        }

        // Main functions
        public static void AnimalPrintSpecies(List<Animal> animals)
        // Prints the species of every animal
        { foreach (Animal animal in animals) { Console.WriteLine($"- {animal.GetSpecies()}"); } }

        public static void AnimalPrintSounds(List<Animal> animals)
        // Prints the sound of every animal
        { foreach (Animal animal in animals) {   animal.MakeSound(); } }

        public static double CombinedPriceAnimals(List<Animal> animals)
        // Prints out the combined price of every animal
        {
            double totalPrice = 0.0;

            foreach (Animal animal in animals) { totalPrice += animal.Price; }

            return totalPrice;
        }

        public static void SellablesPrintNames(List<ISellable> sellables)
        // Prints out the name of every item in stock
        {
            foreach (ISellable sellable in sellables) { Console.WriteLine($"- {sellable.GetName()}"); }
        }

        public static double CombinedPriceSellables(List<ISellable> sellables)
        // Prints out the combined price of every sellable item
        {
            double totalPrice = 0.0;

            foreach (ISellable sellable in sellables) { totalPrice += sellable.GetPrice(); }

            return totalPrice;
        }

        public static double CombinedWeightSellables(List<ISellable> sellables)
        // Prints out the combined weight of every sellable
        {
            double totalWeight = 0.0;

            foreach (ISellable sellable in sellables) { totalWeight += sellable.GetWeight(); }

            return totalWeight;
        }
    }
}
