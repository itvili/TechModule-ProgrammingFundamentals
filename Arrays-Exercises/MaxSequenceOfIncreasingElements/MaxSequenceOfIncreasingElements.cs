using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            //Works only with digits, not with numbers
            var input = Console.ReadLine().Split(' ');
            input = input.Select(l => String.Join(" ", l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))).ToArray();


            long[] inputNumbers = input
                .Select(long.Parse)
                .ToArray();
            long curentMaxlenght = 1;
            long bestLength = 1;

            string increasingElements = "";
            string finalySecuense = input[0];


            for (int i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] - inputNumbers[i - 1] == 1)
                {
                    curentMaxlenght++;
                    finalySecuense += $"{input[i]}";
                }
                else
                {
                    curentMaxlenght = 1;
                    finalySecuense = input[i];
                }
                if (curentMaxlenght > bestLength)
                {

                    bestLength = curentMaxlenght;
                    increasingElements = finalySecuense;



                }
            }
            char[] increasingElementsArr = increasingElements.ToArray();

            Console.WriteLine(string.Join(" ", increasingElementsArr));


        }
    }
}
