using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            CalculateLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);


        }
        static void CalculateLongerLine(double x1, double y1, double x2, double y2,double x3, 
            double y3, double x4, double y4)
        {
            double firstLine = Math.Pow(x1-x2,2) + Math.Pow(y1-y2, 2);
            double secondLine = Math.Pow(x3-x4, 2) + Math.Pow(y3-y4, 2);
            
            if (firstLine > secondLine)
            {
                CalculateNearestDotToTheCenterPoint(x1, y1, x2, y2);
            }
            else
            {

                CalculateNearestDotToTheCenterPoint(x3, y3, x4, y4);
            }

        }
        static void CalculateNearestDotToTheCenterPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secondPoint = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (firstPoint > secondPoint)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1,y1);
            }
            else
            {

                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2,y2);
            }

        }
    }
}
