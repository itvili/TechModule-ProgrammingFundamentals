using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int curentMaxlenght = 1;
            int bestLength = 1;
            int bestSequence = 1;
            bestSequence = inputNumbers[0];
            

              for (int i = 1; i < inputNumbers.Length; i++)
                {
                if (inputNumbers[i] == inputNumbers[i -1])
                {
                    curentMaxlenght++;

                }
                else
                {
                    curentMaxlenght = 1;
                }
                if (curentMaxlenght > bestLength)
                {

                    bestLength = curentMaxlenght;
                    bestSequence = inputNumbers[i];
                    
                }
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write("{0} ", bestSequence);
            }

        }
    }
}
