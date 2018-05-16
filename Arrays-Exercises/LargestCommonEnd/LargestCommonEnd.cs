using System;
using System.Linq;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstSequence = Console.ReadLine().Split(' ').ToArray();
            string[] secondSequence = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(LargestCommonEnd1(firstSequence, secondSequence));

        }

        static int LargestCommonEnd1(string[] firstSequence, string[] secondSequence)
        {
            int counterRight = 0;
            int counterLeft = 0;
            int maxLength = Math.Max(firstSequence.Length, secondSequence.Length);
            int i = 0;
            int j = 1;
            

            while (counterLeft< firstSequence.Length&& counterLeft<secondSequence.Length)
            {
                if (firstSequence[i % firstSequence.Length] == secondSequence[i % secondSequence.Length])
                {
                    counterLeft++;
                }
                else break;
                i++;

            }

            while (counterRight < firstSequence.Length && counterRight < secondSequence.Length)
            {
                if (firstSequence[firstSequence.Length-j] == secondSequence[secondSequence.Length-j])
                {
                    counterRight++;
                }
                else break;
                j++;
                
            }

            if (counterLeft>counterRight)
            {
                return counterLeft;
            }
            else if (counterLeft <= counterRight&&counterRight>=0&&counterLeft>=0)
            {
                return counterRight;

            }
            else
            {
                return 0;
            }
        }
    }
}
