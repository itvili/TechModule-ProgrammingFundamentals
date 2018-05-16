using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ClosestTwoPoints
{
    class Program
    {
        class Points
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Points> points = new List<Points>();

            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Points p = new Points { X = input[0], Y = input[1] };
                points.Add(p);
            }

            double minDistance = double.MaxValue;
            double curentDistance = 0.0;
            Points minPoints1 = new Points();
            Points minPoints2 = new Points();



            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j <points.Count; j++)
                {
                    if (points[i]!=points[j])
                    {
                        curentDistance = CalculateDistance(points[i], points[j]);

                        if (curentDistance < minDistance)
                        {
                            minDistance = curentDistance;
                            minPoints1 = points[i];
                            minPoints2 = points[j];
;
                        }
                    }
                }
            }

            Console.WriteLine("{0:f3}", minDistance);
            Console.WriteLine("({0}, {1})", minPoints1.X, minPoints1.Y);
            Console.WriteLine("({0}, {1})", minPoints2.X, minPoints2.Y);
            
        }
        static double CalculateDistance(Points p1,Points p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);

            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
    }
}
