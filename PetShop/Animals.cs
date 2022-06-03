using System;

namespace PetShop
{
    public abstract class Animal
    {
        public string sound { get; private protected set; }
        public double price { get; private protected set; }
        public double weight { get; private protected set; }

        public virtual string GetSpecies() => GetType().Name;
        public virtual void MakeSound() => Console.WriteLine(sound);
    }

    // Individual Animals
    public class Dog : Animal
    {
        /// <summary>
        /// Constructor for Dog. Sets defaults props.
        /// </summary>
        public Dog()
        {
            sound = "Woof woof";
            price = 249.99;
            weight = 15;
        }
    }

    public class Bird : Animal
    {
        /// <summary>
        /// Constructor for Bird. Sets defaults props.
        /// </summary>
        public Bird()
        {
            sound = "Tweet";
            price = 49.99;
            weight = 0.25;
        }
    }


public class Fish : Animal
    {
        /// <summary>
        /// Constructor for Fish. Sets defaults props.
        /// </summary>
        public Fish()
        {
            sound = "Blub blub";
            price = 4.99;
            weight = 0.1;
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
            sound = "Feed me the flesh of the fallen";
            price = 30;
            weight = 0.64;
        }
    }
}
