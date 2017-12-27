using System;
using System.Collections.Generic;
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
            int speed = int.Parse(tokens[1]);
            int power = int.Parse(tokens[2]);

            int weight = int.Parse(tokens[3]);
            string type = tokens[4];

            double tyre1Pressure = double.Parse(tokens[5]);
            int tyre1Age = int.Parse(tokens[6]);

            double tyre2Pressure = double.Parse(tokens[7]);
            int tyre2Age = int.Parse(tokens[8]);

            double tyre3Pressure = double.Parse(tokens[9]);
            int tyre3Age = int.Parse(tokens[10]);

            double tyre4Pressure = double.Parse(tokens[11]);
            int tyre4Age = int.Parse(tokens[12]);

            cars[i] = new Car(model, new Engine(speed, power), new Cargo(type, weight), 
                new List<Tire> { new Tire(tyre1Pressure, tyre1Age),
                new Tire(tyre2Pressure, tyre2Age), new Tire(tyre3Pressure, tyre3Age), new Tire(tyre4Pressure, tyre4Age) });
        }

        string command = Console.ReadLine();

        if (command == "fragile")
        {
            cars.Where(c => c.cargo.type == "fragile").Where(c => c.tires.Any(t => t.pressure < 1)).Select(c => c.model).ToList().ForEach(Console.WriteLine);
        }
        else if (command == "flamable")
        {
            cars.Where(c => c.cargo.type == "flamable").Where(c => c.engine.power > 250).Select(c => c.model).ToList().ForEach(Console.WriteLine);
        }

    }
}

