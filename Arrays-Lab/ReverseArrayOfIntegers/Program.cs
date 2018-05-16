using System;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] sequence = new int[number];

            for (int i = 0; i < number; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                sequence[i] = readNumber;
            }
            

            for (int j = number-1; j>=0; j--)
            {

                Console.Write("{0} ",sequence[j]);
            }
        }
    }
}
