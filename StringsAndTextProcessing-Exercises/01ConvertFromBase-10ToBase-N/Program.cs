using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().ToArray();

            int baseNnumber = int.Parse(inputNumbers[0]);
            BigInteger base10Number = BigInteger.Parse(inputNumbers[1]);

            BigInteger reminder = 0;
            BigInteger quotient = 1;
            List<BigInteger> binary = new List<BigInteger>();

            while (quotient>0)
            {
                quotient = base10Number / baseNnumber;
                reminder = base10Number% baseNnumber;

                base10Number = quotient;

                binary.Add(reminder);

            }
            binary.Reverse();
            Console.WriteLine(String.Join("",binary));
        }
    }
}
