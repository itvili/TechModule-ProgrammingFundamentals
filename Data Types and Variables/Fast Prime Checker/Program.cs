using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int number = 2; number <= endNumber; number++)

            {
                bool resultFalseOrTrue = true;

                for (int divider = 2; divider <= Math.Sqrt(number); divider++)

                {
                    if (number % divider == 0)

                    {
                        resultFalseOrTrue = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} -> {resultFalseOrTrue}");
            }
        }
    }
}
