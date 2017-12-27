using System;

namespace _02.Wild_Farm.Models.Animals
{
    public class Zebra : Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion)
        {

        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegatable")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            base.Eat(food);
        }

        public override string MakeSound()
        {
            return "Zs";
        }
    }
}
