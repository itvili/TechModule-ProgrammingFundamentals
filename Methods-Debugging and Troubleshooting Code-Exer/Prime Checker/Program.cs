using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            bool isPrime=true;

           
            for (long divider = 2L; divider <= Math.Sqrt(number); divider++)
                {
                    if (number%divider==0)
                    {
                        isPrime = false;
                        break;
                    }
                }

            if (number == 1) return false;
            if (number == 2) return true;
            if (number == 0) return false;
            return isPrime;
        }
    }
}
