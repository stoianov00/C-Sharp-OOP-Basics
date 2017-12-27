using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
       
        Rectangle[] rectangles = new Rectangle[n[0]];

        for (int i = 0; i < n[0]; i++)
        {
            string[] tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string id = tokens[0];
            double width = double.Parse(tokens[1]);
            double height = double.Parse(tokens[2]);
            double x = double.Parse(tokens[3]);
            double y = double.Parse(tokens[4]);

            rectangles[i] = new Rectangle(id, width, height, x, y);
        }

        for (int i = 0; i < n[1]; i++)
        {
            string[] tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            Rectangle rect1 = rectangles.First(r => r.id == tokens[0]);
            Rectangle rect2 = rectangles.First(r => r.id == tokens[1]);
            Console.WriteLine(rect1.Intersects(rect2));
        }

    }
}

