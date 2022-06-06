using System;

namespace PetShop
{
    public abstract class Animal
    {
        public string Sound { get; private protected set; }
        public double Price { get; private protected set; }
        public double Weight { get; private protected set; }

        public virtual string GetSpecies() => GetType().Name;
        public virtual void MakeSound() => Console.WriteLine(Sound);
    }

    // Individual Animals
    public class Dog : Animal
    {
        /// <summary>
        /// Constructor for Dog. Sets defaults props.
        /// </summary>
        public Dog()
        {
            Sound = "Woof woof";
            Price = 249.99;
            Weight = 15;
        }
    }

    public class Bird : Animal
    {
        /// <summary>
        /// Constructor for Bird. Sets defaults props.
        /// </summary>
        public Bird()
        {
            Sound = "Tweet";
            Price = 49.99;
            Weight = 0.25;
        }
    }


    public class Fish : Animal
    {
        /// <summary>
        /// Constructor for Fish. Sets defaults props.
        /// </summary>
        public Fish()
        {
            Sound = "Blub blub";
            Price = 4.99;
            Weight = 0.1;
        }
    }

    public class Blåhaj : Animal
    {
        /// <summary>
        /// Constructor for Blåhaj. Sets defaults props.
        /// Behold the Blåhaj: https://i.imgur.com/BXkQR2E.png https://i.imgur.com/ClqpU4f.mp4
        /// </summary>
        public Blåhaj()
        {
            Sound = "Feed me the flesh of the fallen";
            Price = 30;
            Weight = 0.64;
        }
    }
}
