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
        // This doesn't feel like the right way to do this. Too roundabout? Like, why would you use this over an abstract class?
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
