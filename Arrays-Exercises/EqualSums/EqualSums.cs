using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            int element = 0;
           

            for (int i = 0; i < inputArr.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    sumRight += inputArr[j];
                }
                for (int k = 0; k < i; k++)
                {
                    sumLeft += inputArr[k];
                }
                if (sumRight == sumLeft)
                {
                    element = i;
                    break;
                }
            }

            
            if (sumRight == sumLeft)
            {
                Console.WriteLine("{0} ", element);
                
            }
            else if (sumLeft == 0 && sumRight == 0)
            {
                Console.WriteLine(sumRight);

            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
