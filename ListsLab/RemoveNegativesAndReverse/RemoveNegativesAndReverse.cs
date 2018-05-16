using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List <int> listWithoutNegativesNumbers = new List<int>();

            int counter = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]>=0)
                {
                   listWithoutNegativesNumbers.Add(input[i]);
                    counter++;
                }
            }

            listWithoutNegativesNumbers.Reverse();

            if (counter==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", listWithoutNegativesNumbers));
            }
            
        }
    }
}
