using System;
using System.Linq;
using System.Reflection;
namespace _01.Class_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var box = new Box();

                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Type boxType = typeof(Box);
                FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                Console.WriteLine(fields.Count());

                Console.WriteLine(box.SurfaceArea(length, width, height));
                Console.WriteLine(box.LateralSurfaceArea(length, width, height));
                Console.WriteLine(box.Volume(length, width, height));
                
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
