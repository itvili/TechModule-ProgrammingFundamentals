using System;

namespace _01ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = String.Empty;

            for (int i = input.Length-1; i >=0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed.ToString());
        }
    }
}
