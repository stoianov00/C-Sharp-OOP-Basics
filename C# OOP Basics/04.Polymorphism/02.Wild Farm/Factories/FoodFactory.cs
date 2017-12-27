using System;
using _02.Wild_Farm.Models;
using _02.Wild_Farm.Models.Foods;

namespace _02.Wild_Farm.Factories
{
    public class FoodFactory
    {
        public static Food GetFood(string[] tokens)
        {
            string foodType = tokens[0];
            int foodQuantity = int.Parse(tokens[1]);

            if (foodType == "Meat")
            {
                return new Meat(foodQuantity);
            }
            return new Vegetable(foodQuantity);
        }


    }
}
