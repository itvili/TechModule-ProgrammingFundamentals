using System;
using System.Linq;

namespace _04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var largestNumbers = new int[3];
            if (inputNumbers.Length<3)
            {
                largestNumbers = inputNumbers.OrderByDescending(x => x).Take(inputNumbers.Length).ToArray();
            }
            else
            {
                largestNumbers = inputNumbers.OrderByDescending(x => x).Take(3).ToArray();

            }

            Console.WriteLine(string.Join(" ", largestNumbers));


        }
    }
}
