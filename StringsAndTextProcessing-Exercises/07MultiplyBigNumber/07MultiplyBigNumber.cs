using System;
using System.Collections.Generic;

namespace _07MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberInput = Console.ReadLine().TrimStart('0');
            var multiplierInput = Console.ReadLine();

            char[] number = numberInput.ToCharArray();
            char multiplier =char.Parse(multiplierInput);


            int product = 0;
            int reminder = 0;
            char NumberAfterMultpl = ' ';
            List<char> totalSum = new List<char>();
            for (int i = 0; i < number.Length; i++)
            {
                int numberToMultiply = (int)(number[number.Length - 1 - i]) - 48;
                int multiplierInt = multiplier - 48;
                product =numberToMultiply* multiplierInt + reminder;
                char[] sumLikeChar = product.ToString().ToCharArray();
                if (sumLikeChar.Length > 1)
                {
                    reminder = sumLikeChar[0] - 48;
                    NumberAfterMultpl = sumLikeChar[1];
                }
                else
                {
                    NumberAfterMultpl = sumLikeChar[0];
                    reminder = 0;
                }
                totalSum.Add(NumberAfterMultpl);
                if (sumLikeChar.Length > 1)
                {
                    if (i == number.Length - 1)
                    {
                        totalSum.Add(sumLikeChar[0]);
                    }
                }
            }
            if (true)
            {

            }
            
            var countOfZero = totalSum.FindAll(x=>x=='0');
            if (totalSum.Count==countOfZero.Count)
            {
                Console.WriteLine("0");
            }
            else
            {
                totalSum.Reverse();
                Console.WriteLine(string.Join("", totalSum));
            }
            
        }
    }
}
