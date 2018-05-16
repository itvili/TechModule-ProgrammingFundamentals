using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial=(Factorial(number));
            Console.WriteLine(CountTrailingZero(factorial));
            
        }
        static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static BigInteger CountTrailingZero(BigInteger factorialNumber)
        {
            BigInteger counter = 0L;
            while (factorialNumber>0&&factorialNumber%10==0)
            {
                factorialNumber= factorialNumber / 10;
                counter++;
            }
            return counter;
        }
    }
}
