using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int diference = 1;

            for (int i = 0; i < input.Length/2; i++)
            {
                
                string tempString = input[i];
                input[i] = input[input.Length - diference];
                input[input.Length - diference] = tempString;
                diference++;
                
            }
           
            Console.Write(string.Join(" ", input));
            Console.WriteLine();
        }
    }
}
