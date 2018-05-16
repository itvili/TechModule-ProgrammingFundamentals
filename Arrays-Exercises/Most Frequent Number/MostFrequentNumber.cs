using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            ulong[] input = Console.ReadLine()
                           .Split(' ')
                           .Select(ulong.Parse)
                           .ToArray();

            ulong curentMaxCount = 0;
            ulong bestMaxCount = 0;

            ulong bestMaxNumber = input[0];

            for (ulong i = 0; i < (ulong)input.Length; i++)
            {
                curentMaxCount = 0;
                for (ulong j = 0; j < (ulong)input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        curentMaxCount++;

                    }

                }
                if (curentMaxCount > bestMaxCount)
                {
                    bestMaxCount = curentMaxCount;
                   
                    bestMaxNumber = input[i];
                }

            }

            Console.WriteLine(bestMaxNumber);
                       
        }
    }
}
