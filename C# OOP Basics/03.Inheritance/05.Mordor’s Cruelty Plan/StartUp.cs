using System;
using _05.Mordor_s_Cruelty_Plan.Factories;
using _05.Mordor_s_Cruelty_Plan.Models;

namespace _05.Mordor_s_Cruelty_Plan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();
            var gandalf = new Gandalf();

            string[] inputFood = Console.ReadLine()
                .Split(new[] {'\t', ' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var foodStr in inputFood)
            {
                var food = foodFactory.GetFood(foodStr);
                gandalf.Eat(food);
            }

            var totalHapinessPoints = gandalf.GetHapinessPoints();
            Mood cureentMood = moodFactory.GetMood(totalHapinessPoints);

            Console.WriteLine(totalHapinessPoints);
            Console.WriteLine(cureentMood);
        }
    }
}
