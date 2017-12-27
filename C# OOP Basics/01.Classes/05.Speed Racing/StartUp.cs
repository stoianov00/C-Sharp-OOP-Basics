using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());      
        var cars = new Car[n];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string model = tokens[0];

            double fuelAmmount = double.Parse(tokens[1]);
            double fuelCost = double.Parse(tokens[2]);

            cars[i] = new Car(model, fuelAmmount, fuelCost);
        }

        string command = Console.ReadLine();
        while (command != "End")
        {
            string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string model = tokens[1];
            double distance = double.Parse(tokens[2]);

            cars.Where(c => c.model == model).ToList().ForEach(c => c.Calculate(distance));

            command = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.model} {car.fuelAmmount:F2} {car.distanceTravelled}");
        }

    }
}

