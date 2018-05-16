using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int curentLenght = 1;
            int bestLenght = 1;
            int bestStart = input[0];
            int curentStart = input[0];

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    curentLenght++;
                    curentStart = input[i - 1];


                }
                else
                {
                    curentLenght = 1;
                    curentStart = input[0];

                }
                if (curentLenght > bestLenght)
                {
                    bestStart = curentStart;
                    bestLenght = curentLenght;
                }
            }
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write("{0} ", bestStart);
            }


        }

    }
}
