using System;
using System.Linq;

namespace _03CirclesIntersection
{
    class Program
    {
        class Point
        {
            public double X { set; get; }
            public double Y { set; get; }

        }
        class Circle
        {
            public Point Center { set; get; }
            public double Radius { set; get; }

        }
        static void Main(string[] args)
        {
            Circle circle1 = GetCircle();
            Circle circle2 = GetCircle();
            double distance= GetDistance(circle1, circle2);

            if (distance<=circle1.Radius+circle2.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        private static double GetDistance(Circle circle1, Circle circle2)
        {
            double a = Math.Abs(circle1.Center.X - circle2.Center.X);
            double b = Math.Abs(circle1.Center.Y - circle2.Center.Y);
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        private static Circle GetCircle()
        {
            double[] input = Console.ReadLine()
                            .Split(' ')
                            .Select(double.Parse)
                            .ToArray();

            Point centerPoint = new Point { X = input[0], Y = input[1] };

            Circle circle = new Circle { Center = centerPoint, Radius = input[2] };
            return circle;
        }
    }
}
