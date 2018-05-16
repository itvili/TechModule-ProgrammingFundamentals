using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().ToArray();

            BigInteger baseN = BigInteger.Parse(inputNumbers[0]);
            BigInteger lenght = inputNumbers[1].Length;
            var baseNnumber =BigInteger.Parse( inputNumbers[1]);

            BigInteger convertedNumber  = 0;
            
            List<BigInteger> base10 = new List<BigInteger>();
            

            for (int i = 0; i <lenght; i++)
            {
                BigInteger lastDigit = baseNnumber % 10; // get the last digit
                convertedNumber = convertedNumber+lastDigit*BigInteger.Pow(baseN, i);
                baseNnumber = baseNnumber / 10; //remove the last digit

            }


            Console.WriteLine(convertedNumber);
        }
    }
}
