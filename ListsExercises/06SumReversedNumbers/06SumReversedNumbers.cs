using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SumReversedNumbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            
            int sum = 0;

            for (int i = 0; i <input.Count; i++)
            {
               
                int numberToSum = ConvertStringToInt(input, i);

                sum += numberToSum;
                       
            }
            
            Console.WriteLine(sum);
           
        }
        static int ConvertStringToInt(List<string> input, int i)
        {
           
                string stringToConvert = input[i];

                var charToReverse = stringToConvert.ToCharArray();
                Array.Reverse(charToReverse);
                string stringToSum = new string(charToReverse);

                int numberToSum = int.Parse(stringToSum);

                return numberToSum;

            
        }
    }
}
