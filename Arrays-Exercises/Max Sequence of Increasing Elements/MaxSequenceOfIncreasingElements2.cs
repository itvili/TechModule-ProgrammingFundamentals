using System;
using System.Linq;

namespace Max_Sequence_of_Increasing_Elements
{
    class MaxSequenceOfIncreasingElements2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            input = input.Select(l => String.Join(" ", l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))).ToArray();


            long[] inputNumbers = input
                .Select(long.Parse)
                .ToArray();
            long curentMaxlenght =1L;
            long bestLength = 1L;
            long bestStartFromI = 0L;
            long curentStartFromI = 0L;
                        
            for (long i = 1L; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] - inputNumbers[i - 1] >= 1)
                {
                    curentMaxlenght++;
                       
                }
                else
                {
                    curentMaxlenght = 1;
                    curentStartFromI = i;
                 
                }

                if (curentMaxlenght > bestLength)
                {
                    bestLength = curentMaxlenght;
                    bestStartFromI = curentStartFromI;

                }

            }
           

            for (long i = bestStartFromI; i < bestLength + bestStartFromI; i++)
            {
                Console.Write("{0} ", inputNumbers[i]);
            }



        }
    }
}
