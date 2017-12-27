using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            string[] tokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                string[] tok = token.Split('=');
                string name = tok[0].Trim();
                decimal money = decimal.Parse(tok[1].Trim());
                try
                {
                    persons.Add(new Person(name, money));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            tokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                string[] tok = token.Split('=');
                string name = tok[0].Trim();
                decimal cost = decimal.Parse(tok[1].Trim());
                try
                {
                    products.Add(new Product(name, cost));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens[0];
                string productName = tokens[1];

                var person = persons.First(p => p.Name == personName);
                var product = products.First(p => p.Name == productName);

                if (person.Money >= product.Cost)
                {
                    person.Money -= product.Cost;
                    person.AddProductToBag(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }

                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                if (person.SeeBag().Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.SeeBag().Select(p => p.Name))}");
                }
                else
                {   
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }

        }
    }
}