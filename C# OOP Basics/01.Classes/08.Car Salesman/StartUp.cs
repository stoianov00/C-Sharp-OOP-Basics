using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int enginesCount = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();

        for (int i = 0; i < enginesCount; i++)
        {
            string[] input = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            string power = input[1];

            if (input.Length == 2)
            {
                engines.Add(new Engine(model, power));
            }
            else if (input.Length == 3)
            {
                int displacement;
                bool isDisplacement = int.TryParse(input[2], out displacement);
                if (isDisplacement)
                {
                    engines.Add(new Engine(model, power, displacement));
                }
                else
                {
                    string efficiency = input[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
            }
            else if (input.Length == 4)
            {
                int displacement = int.Parse(input[2]);
                string efficiency = input[3];
                engines.Add(new Engine(model, power, displacement, efficiency));
            }
        }

        int carsCount = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < carsCount; i++)
        {
            string[] input = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];
            string engineModel = input[1];
            Engine engine = new Engine(null, null);

            foreach (Engine eng in engines)
            {
                if (eng.model == engineModel)
                {
                    engine = eng;
                }
            }

            if (input.Length == 2)
            {
                cars.Add(new Car(model, engine));
            }
            else if (input.Length == 3)
            {
                int weight;
                bool isWeight = int.TryParse(input[2], out weight);
                if (isWeight)
                {
                    cars.Add(new Car(model, engine, weight));
                }
                else
                {
                    string color = input[2];
                    cars.Add(new Car(model, engine, color));
                }
            }
            else if (input.Length == 4)
            {
                int weight = int.Parse(input[2]);
                string color = input[3];
                cars.Add(new Car(model, engine, weight, color));
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.model}:");
            Console.WriteLine($"  {car.engine.model}:");
            Console.WriteLine($"    Power: {car.engine.power}");
            Console.WriteLine("    Displacement: {0}", car.engine.displacement == 0 ? "n/a" : car.engine.displacement.ToString());
            Console.WriteLine($"    Efficiency: {car.engine.efficiency}");
            Console.WriteLine("  Weight: {0}", car.weight == 0 ? "n/a" : car.weight.ToString());
            Console.WriteLine($"  Color: {car.color}");
        }
    }
}
    

