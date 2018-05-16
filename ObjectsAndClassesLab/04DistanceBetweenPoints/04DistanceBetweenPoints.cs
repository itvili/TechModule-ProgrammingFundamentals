using System;
using System.Linq;

namespace _04DistanceBetweenPoints
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
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Points p1 = new Points() { X = firstLine[0], Y = firstLine[1] };
            Points p2 = new Points() { X = secondLine[0], Y = secondLine[1] };

            Console.WriteLine("{0:0.000}", CalculateDistance(p1,p2));

        }
        static double CalculateDistance(Points p1, Points p2)
        {
            int a = Math.Abs(p1.X - p2.X);
            int b = Math.Abs(p1.Y - p2.Y);

            double distanse = Math.Sqrt(a * a + b * b);
            return distanse;
        }

    }
}
