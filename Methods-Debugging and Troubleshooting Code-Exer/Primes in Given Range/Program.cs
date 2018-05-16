using System;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            FindPrimesInRange(firstNumber, secondNumber);
        }
        static void FindPrimesInRange(int startNum,int endNum)
        {
            bool isPrime = true;
            string myPprimes = "";
            for (int number = startNum; number <= endNum; number++)
            {
                isPrime = true;
                                
                for (int i = 2; i <=Math.Sqrt(number); i++)
                {
                   
                    if (number%i==0)
                    {
                        isPrime = false;
                        break;
                        
                    }
                   

                }
                if (number == 1 || number == 0)
                {
                    isPrime = false;
                }
                if (number == 2)
                {
                    isPrime = true;
                }
                if (isPrime)
                {
                    
                   string primes =String.Format("{0}, ", number);
                    myPprimes = myPprimes + primes;
                             
                }
                
            }
            myPprimes = myPprimes.Substring(0, myPprimes.Length - 2);
            Console.Write(myPprimes);
            Console.WriteLine();
        }
    }
}
