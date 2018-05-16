using System;
using System.Collections.Generic;

namespace _06SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            var firstInput = Console.ReadLine().TrimStart(new char[] { '0' });
            var secondInput = Console.ReadLine().TrimStart(new char[] { '0' });

            char[] firstNumber = firstInput.ToCharArray();
            char[] secondNumber = secondInput.ToCharArray();

            int minLength = Math.Min(firstNumber.Length, secondNumber.Length);
            int maxLength = Math.Max(firstNumber.Length, secondNumber.Length);

            int sum = 0;
            int reminder = 0;
            char numberAfterSum = ' ';
            List<char> totalSum = new List<char>();
            for (int i = 0; i < minLength; i++)
            {
                sum = firstNumber[firstNumber.Length-1-i] + secondNumber[secondNumber.Length-1-i]-96+reminder;
                char[] sumLikeChar = sum.ToString().ToCharArray();
                if (sumLikeChar.Length>1)
                {
                    reminder = sumLikeChar[0]-48;
                    numberAfterSum = sumLikeChar[1];
                    if (minLength==1&&maxLength==1)
                    {
                        totalSum.Add(sumLikeChar[1]);
                        totalSum.Add(sumLikeChar[0]);
                        break;
                    }
                }
                else
                {
                    numberAfterSum = sumLikeChar[0];
                    reminder = 0;
                }
                totalSum.Add(numberAfterSum);
            }

            if (maxLength != minLength)
            {
                char[] longerInput = firstNumber.Length > secondNumber.Length ? longerInput = firstNumber : longerInput = secondNumber;
                for (int i = 0; i < maxLength - minLength; i++)
                {
                    if (reminder != 0)
                    {
                        sum = longerInput[maxLength - minLength - 1 - i] + reminder - 48;
                        char[] sumLikeChar = sum.ToString().ToCharArray();
                        if (sumLikeChar.Length > 1)
                        {
                            reminder = sumLikeChar[0]-48;
                            numberAfterSum = sumLikeChar[1];
                        }
                        else
                        {
                            numberAfterSum = sumLikeChar[0];
                            reminder = 0;
                        }
                        
                        totalSum.Add(numberAfterSum);
                        if (sumLikeChar.Length > 1)
                        {
                            if (i == maxLength - minLength - 1)
                            {
                                totalSum.Add(sumLikeChar[0]);
                            }
                        }
                       
                    }
                    else
                    {
                        totalSum.Add(longerInput[maxLength - minLength - 1 -i]);
                    }
                }
            }
            totalSum.Reverse();
            Console.WriteLine(string.Join("",totalSum));
        }
    }
}
