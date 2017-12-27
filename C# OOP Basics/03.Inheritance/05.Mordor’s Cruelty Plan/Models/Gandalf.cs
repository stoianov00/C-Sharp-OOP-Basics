using System.Collections.Generic;
using System.Linq;

namespace _05.Mordor_s_Cruelty_Plan.Models
{
    public class Gandalf
    {
        private List<Food> foodsEatenByGandalf;

        public Gandalf()
        {
            this.foodsEatenByGandalf = new List<Food>();
        }

        public void Eat(Food food)
        {
            this.foodsEatenByGandalf.Add(food);
        }
        
        public int GetHapinessPoints()
        {
            return this.foodsEatenByGandalf.Sum(f => f.GetHapinessPoints());
        }

    }
}
