using System;
using _02.Wild_Farm.Factories;
using _02.Wild_Farm.Models;
using _02.Wild_Farm.Models.Animals;

namespace _02.Wild_Farm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] animalTokens = inputLine.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string[] foodTokens = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.GetAnimal(animalTokens);
                Food food = FoodFactory.GetFood(foodTokens);

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(animal);
            }

        }
    }
}
