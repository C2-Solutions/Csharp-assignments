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
            public int AgeAnimal { get; set; }
            public string ChildOf { get; set; }
        }

        static void Main(string[] args)
        {
            List<Animal> AllAnimals = new List<Animal>()
            {
                new Animal() { NameAnimal = "a01", AgeAnimal = 80 },
                new Animal() { NameAnimal = "a02", AgeAnimal = 72 },
                new Animal() { NameAnimal = "a03", AgeAnimal = 75 },
                new Animal() { NameAnimal = "a04", AgeAnimal = 40 },
                new Animal() { NameAnimal = "a05", AgeAnimal = 30 },
                new Animal() { NameAnimal = "a06", AgeAnimal = 76 },
                new Animal() { NameAnimal = "a07", AgeAnimal = 59 },
                new Animal() { NameAnimal = "b01", AgeAnimal = 60, ChildOf = "a01" },
                new Animal() { NameAnimal = "b02", AgeAnimal = 60, ChildOf = "a01" },
                new Animal() { NameAnimal = "b03", AgeAnimal = 50, ChildOf = "a02" },
                new Animal() { NameAnimal = "b04", AgeAnimal = 61, ChildOf = "a03" },
                new Animal() { NameAnimal = "b05", AgeAnimal = 50, ChildOf = "a06" },
                new Animal() { NameAnimal = "b06", AgeAnimal = 43, ChildOf = "a06" },
                new Animal() { NameAnimal = "c01", AgeAnimal = 40, ChildOf = "b01" },
                new Animal() { NameAnimal = "c02", AgeAnimal = 42, ChildOf = "b02" },
                new Animal() { NameAnimal = "c03", AgeAnimal = 45, ChildOf = "b04" },
                new Animal() { NameAnimal = "c04", AgeAnimal = 39, ChildOf = "b04" },
                new Animal() { NameAnimal = "c05", AgeAnimal = 35, ChildOf = "b04" },
                new Animal() { NameAnimal = "c06", AgeAnimal = 22, ChildOf = "b06" },
                new Animal() { NameAnimal = "d01", AgeAnimal = 22, ChildOf = "c01" },
                new Animal() { NameAnimal = "d02", AgeAnimal = 16, ChildOf = "c01" },
                new Animal() { NameAnimal = "d03", AgeAnimal = 11, ChildOf = "c02" },
                new Animal() { NameAnimal = "d04", AgeAnimal = 20, ChildOf = "c03" },
                new Animal() { NameAnimal = "d05", AgeAnimal = 19, ChildOf = "c03" },
                new Animal() { NameAnimal = "d06", AgeAnimal = 18, ChildOf = "c03" },
                new Animal() { NameAnimal = "d07", AgeAnimal = 10, ChildOf = "c04" },
                new Animal() { NameAnimal = "d08", AgeAnimal = 2, ChildOf = "c06" },
                new Animal() { NameAnimal = "d09", AgeAnimal = 1, ChildOf = "c06" }
            };

            /*            Console.WriteLine("Schrijf een leeftijd van een dier");
                        int Age = Convert.ToInt32(Console.ReadLine());

                        IEnumerable<Animal> query = AllAnimals.Where(Animal => Animal.AgeAnimal == Age);
                        foreach (Animal Animal in query)
                        {
                            Console.WriteLine("{0} is {1} jaar oud",Animal.NameAnimal, Animal.AgeAnimal);
                        }*/

            int num = 1;
            foreach (Animal animal in AllAnimals.Where(Animal => Animal.ChildOf == null))
            {
                string gen1 = "a0" + num;
                IEnumerable<Animal> query = AllAnimals.Where(Animal => Animal.ChildOf == gen1);
                Console.WriteLine("{0} heeft {1} kinderen\n", gen1, query.Count());
                Console.WriteLine("");
                num++;
            }
        }
    }
}
