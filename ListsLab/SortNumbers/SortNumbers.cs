using System;
using System.Linq;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            input.Sort();

            Console.WriteLine(String.Join(" <= ", input));
        }
    }
}
