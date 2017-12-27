using System;
namespace _01.Class_Box
{
    class Box
    {
        private double length;
        private double width;
        private double height;
        




        public string SurfaceArea(double length, double width, double height)
        {
            Exceptions(length, width, height);
            double result = 2 * length * width + 2 * length * height + 2 * width * height;
            return string.Format($"Surface Area - {result:F2}");
        }

        public string LateralSurfaceArea(double length, double width, double height)
        {
            Exceptions(length, width, height);
            double result = 2 * length * height + 2 * width * height;
            return string.Format($"Lateral Surface Area - {result:F2}");
        }

        public string Volume(double length, double width, double height)
        {
            Exceptions(length, width, height);
            double result = length * width * height;
            return string.Format($"Volume - {result:F2}");
        }

        public void Exceptions(double length, double width, double height)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else if (width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
        }


    }
}
