using System;

namespace PetShop
{
    public interface ISellable
    {
        string GetName()
            {
                return GetType().Name;
            }
        double GetPrice();
        double GetWeight();
    }

    public class Toys : ISellable
    {
        /// <summary>
        /// Constructor for Toys. Sets default props, assuming a tennis ball.
        /// </summary>
        public double GetPrice()
        {
            return 5.99;
        }

        public double GetWeight()
        {
            return 0.056;
        }

    }
    
    public class Food : ISellable
    {
        /// <summary>
        /// Constructor for Food. Sets default props, assuming dog food.
        /// </summary>
        public double GetPrice()
        {
            return 18.89;
        }

        public double GetWeight()
        {
            return 0.25;
        }
    }
}
