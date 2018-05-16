using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            double widhtOrSide = 0.0;
            double height = 0.0;
            double radiusOrSide = 0.0;


            if (figureType=="triangle"||figureType=="rectangle")
            {
                widhtOrSide = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}",CalculateTriangleOrRectangleArea(widhtOrSide,height,figureType));
            }
            else
            {
                radiusOrSide = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}", CalculateSquareOrCircleArea(radiusOrSide,figureType));
            }
        }

        static double CalculateTriangleOrRectangleArea(double width, double height, string figureType)
        {
            double area = 0.0;
            if (figureType=="triangle")
            {
                return area = width * height / 2;
            }
            else
            {
                return area = width * height;
            }
        }
        static double CalculateSquareOrCircleArea(double sideOrRadius, string figureType)
        {
            double area = 0.0;
            if (figureType == "circle")
            {
                return area = Math.PI*(sideOrRadius*sideOrRadius);
            }
            else
            {
                return area = sideOrRadius * sideOrRadius;
            }
        }

    }
}
