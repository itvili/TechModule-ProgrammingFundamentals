using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lengthOfArrayAccordingMaxNumber = input.Max();

            List<int> listWithNumbersToCompare = new List<int>();

            for (int i = 0; i <= lengthOfArrayAccordingMaxNumber; i++)
            {
                listWithNumbersToCompare.Add(i);
            }

            int counterRepeatNumber = 0;
            int positionInList = 0;
            for (int i = 0; i < lengthOfArrayAccordingMaxNumber; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    
                    int numberToCompare = listWithNumbersToCompare[i];
                    int numberCompared = input[j];
                    if (numberToCompare==numberCompared)
                    {
                        counterRepeatNumber++;
                        positionInList = j;
                    }
                }
                if (counterRepeatNumber > 0)
                {
                    Console.WriteLine("{0} -> {1}", input[positionInList], counterRepeatNumber);
                    counterRepeatNumber = 0;
                }
               
            }
        }
    }
}
