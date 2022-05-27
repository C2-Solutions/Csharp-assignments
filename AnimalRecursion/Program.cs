//Deze opdracht is gemaakt door Bryan Bao, Enno Andel en Michael Vrijburg
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recusieve
{
    internal class Program
    {
        public class Animal
        {
            public string NameAnimal { get; set; }
            public string AgeAnimal { get; set; }
            public string ChildOf { get; set; }
            public string FirstGen { get; set; }
        }

        static void Main(string[] args)
        {
            //De lijst met al de dieren 
            List<Animal> AllAnimals = new List<Animal>()
            {
                new Animal() { NameAnimal = "a01", AgeAnimal = "80" },
                new Animal() { NameAnimal = "a02", AgeAnimal = "72" },
                new Animal() { NameAnimal = "a03", AgeAnimal = "75" },
                new Animal() { NameAnimal = "a04", AgeAnimal = "40" },
                new Animal() { NameAnimal = "a05", AgeAnimal = "30" },
                new Animal() { NameAnimal = "a06", AgeAnimal = "76" },
                new Animal() { NameAnimal = "a07", AgeAnimal = "59" },
                new Animal() { NameAnimal = "b01", AgeAnimal = "60", ChildOf = "a01" },
                new Animal() { NameAnimal = "b02", AgeAnimal = "60", ChildOf = "a01" },
                new Animal() { NameAnimal = "b03", AgeAnimal = "50", ChildOf = "a02" },
                new Animal() { NameAnimal = "b04", AgeAnimal = "61", ChildOf = "a03" },
                new Animal() { NameAnimal = "b05", AgeAnimal = "50", ChildOf = "a06" },
                new Animal() { NameAnimal = "b06", AgeAnimal = "43", ChildOf = "a06" },
                new Animal() { NameAnimal = "c01", AgeAnimal = "40", ChildOf = "b01", FirstGen = "a01" },
                new Animal() { NameAnimal = "c02", AgeAnimal = "42", ChildOf = "b02", FirstGen = "a01" },
                new Animal() { NameAnimal = "c03", AgeAnimal = "45", ChildOf = "b04", FirstGen = "a03" },
                new Animal() { NameAnimal = "c04", AgeAnimal = "39", ChildOf = "b04", FirstGen = "a03" },
                new Animal() { NameAnimal = "c05", AgeAnimal = "35", ChildOf = "b04", FirstGen = "a03" },
                new Animal() { NameAnimal = "c06", AgeAnimal = "22", ChildOf = "b06", FirstGen = "a06" },
                new Animal() { NameAnimal = "d01", AgeAnimal = "22", ChildOf = "c01", FirstGen = "a01" },
                new Animal() { NameAnimal = "d02", AgeAnimal = "16", ChildOf = "c01", FirstGen = "a01" },
                new Animal() { NameAnimal = "d03", AgeAnimal = "11", ChildOf = "c02", FirstGen = "a01" },
                new Animal() { NameAnimal = "d04", AgeAnimal = "20", ChildOf = "c03", FirstGen = "a03" },
                new Animal() { NameAnimal = "d05", AgeAnimal = "19", ChildOf = "c03", FirstGen = "a03" },
                new Animal() { NameAnimal = "d06", AgeAnimal = "18", ChildOf = "c03", FirstGen = "a03" },
                new Animal() { NameAnimal = "d07", AgeAnimal = "10", ChildOf = "c04", FirstGen = "a03" },
                new Animal() { NameAnimal = "d08", AgeAnimal = "2", ChildOf = "c06", FirstGen = "a06" },
                new Animal() { NameAnimal = "d09", AgeAnimal = "1", ChildOf = "c06", FirstGen = "a06" }
            };

            //Deelopdracht 2: De hoeveelheid kinderen van generatie a
            int ChildNum = 1;
            foreach (Animal animal in AllAnimals.Where(Animal => Animal.ChildOf == null))
            {
                string gen1 = "a0" + ChildNum;
                IEnumerable<Animal> query = AllAnimals.Where(Animal => Animal.ChildOf == gen1 || Animal.FirstGen == gen1);
                Console.WriteLine("{0} heeft {1} kinderen\n", gen1, query.Count());
                ChildNum++;
            }

            //Deelopdracht 3: De hoeveelheid kleinkinderen van generatie a
            Console.WriteLine("////////////////////////////////////////////////////\n");
            int GrandChildNum = 1;
            foreach (Animal animal in AllAnimals.Where(Animal => Animal.ChildOf == null))
            {
                string gen1 = "a0" + GrandChildNum;
                IEnumerable<Animal> query = AllAnimals.Where(Animal => Animal.FirstGen == gen1);
                Console.WriteLine("{0} heeft {1} kleinkinderen\n", gen1, query.Count());
                GrandChildNum++;
            }

            //Deelopdracht 1: voer een leeftijd of een naam
            Console.WriteLine("////////////////////////////////////////////////////\n");
            Console.WriteLine("Schrijf een leeftijd van een dier");
            string Input = Console.ReadLine();
            //Hier wordt gecheckt of je wel echt een Naam of leeftijd heb ingevoerd. Anders krijg je een melding
            bool b = AllAnimals.Any(Animal => Animal.AgeAnimal == Input || Animal.NameAnimal == Input);

            if (b == true)
            {
                IEnumerable<Animal> Search = AllAnimals.Where(Animal => Animal.AgeAnimal == Input | Animal.NameAnimal == Input);
                foreach (Animal Animal in Search)
                {
                    Console.WriteLine("{0} is {1} jaar oud", Animal.NameAnimal, Animal.AgeAnimal);
                }
            }
            else
            {
                Console.WriteLine("Voer wat anders in. Er is geen dier dat een leeftijd/Naam heeft van: {0}", Input);
            }
        }
    }
}
