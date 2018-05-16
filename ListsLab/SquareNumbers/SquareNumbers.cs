using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ').
                Select(double.Parse)
                .ToList();

            List<double> resultOfSquareNumbers = new List<double>();

            foreach (var num in input)
            {
                double numSquare = Math.Sqrt(num);
                if (numSquare == (int)numSquare)
                {
                    resultOfSquareNumbers.Add(num);
                }
            }

            resultOfSquareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", resultOfSquareNumbers));
        }
    }
}
