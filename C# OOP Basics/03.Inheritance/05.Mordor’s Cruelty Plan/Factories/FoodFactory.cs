using _05.Mordor_s_Cruelty_Plan.Models;
using _05.Mordor_s_Cruelty_Plan.Models.Foods;

namespace _05.Mordor_s_Cruelty_Plan.Factories
{
    public class FoodFactory
    {
        public Food GetFood(string foodType)
        {
            switch (foodType.ToLower())
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "apple":
                    return new Apple();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Junk();
                    
            }
        }

    }
}