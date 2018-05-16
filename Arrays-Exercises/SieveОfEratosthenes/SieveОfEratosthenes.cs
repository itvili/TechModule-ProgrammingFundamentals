using System;

namespace SieveОfEratosthenes
{
    class SieveОfEratosthenes
    {
        static void Main(string[] args)

        {
            
            long number = long.Parse(Console.ReadLine());

            long[] input = new long[number + 1];
            bool[] checkNumbers = new bool[number + 1];

            for (int i = 0; i <= number; i++)
            {
                input[i] = i;
                checkNumbers[i] = true;
            }

            for (int i = 2; i <=Math.Sqrt(number); i++)
            {
                checkNumbers[0] = false;
                checkNumbers[1] = false;
                if (checkNumbers[i])
                {
                    for (int j = i*i; j <= number; j+=i)
                    {
                        checkNumbers[j] = false;
                        
                    }
                }
            }


            checkNumbers[0] = false;
            checkNumbers[1] = false;
            for (int i = 0; i <= number; i++)
            {
                if (checkNumbers[i] == true)
                {

                    Console.Write("{0} ", input[i]);
                }
            }
        }
    }
}
            

     