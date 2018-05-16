using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CalculateNearestDotToTheCenterPoint(x1, y1, x2, y2);

        }
        static void CalculateNearestDotToTheCenterPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Pow(x1,2) + Math.Pow(y1,2);
            double secondPoint = Math.Pow(x2,2) + Math.Pow(y2,2);
            if (firstPoint>secondPoint)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                
                Console.WriteLine("({0}, {1})", x1, y1);
            }

        }
    }
}
