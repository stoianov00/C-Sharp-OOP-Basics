using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Pizza_Calories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfToppings;

        private const int MinNameLength = 1;
        private const int MaxNameLength = 15;

        private const int MinToppings = 0;
        private const int MaxToppings = 10;
        
        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            this.NumberOfToppings = numberOfToppings;
        }

        public Dough Dough
        {
            set { this.dough = value; }
        } 
        
        public int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            set
            {
                if (value < MinToppings || value > MaxToppings)
                {
                    throw new ArgumentException($"Number of toppings should be in range [{MinToppings}..{MaxToppings}].");
                }
                this.numberOfToppings = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between {MinNameLength} and {MaxNameLength} symbols.");
                }
                this.name = value;
            }
        }

        public void AddTopping(Topping topping) 
        {
            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            return this.dough.GetCalories() + this.toppings.Sum(t => t.GetCalories());
        }
        
    }
}