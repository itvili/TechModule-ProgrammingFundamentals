using System;
using System.Linq;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counterDifference = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                for (int j = i; j < inputNumbers.Length; j++)
                {
                    if (Math.Abs(inputNumbers[i] - inputNumbers[j]) == difference) 
                    {
                        counterDifference++;
                    }
                }
            }

            Console.WriteLine(counterDifference);

        }
    }
}
