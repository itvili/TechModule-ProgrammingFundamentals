using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = Math.Abs(number);

            int multiply = MultiplySumOfOddsByEvenNumber(n);
            Console.WriteLine(multiply);

            
        }
        static int GetSumOdds(int n)
        {
            int sum = 0;
            int lastDigit = 0;
            while (n>0)
            {
                lastDigit = n % 10;
                if (lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                n = n / 10;
            }
            return sum;
        }
        static int GetSumEven(int n)
        {
            int sumEven = 0;
            int lastDigit = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                if (lastDigit%2 == 0)
                {
                    sumEven += lastDigit;
                }
                n = n / 10;
            }
            return sumEven;
        }

        static int MultiplySumOfOddsByEvenNumber(int n)
        {
            int sumOdds = GetSumOdds(n);
            int sumEven = GetSumEven(n);
            return sumEven * sumOdds;
        }
    }
}
