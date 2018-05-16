using System;
using System.Linq;

namespace IndexОfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                           //.Split(' ')
                           //.Select(char.Parse)
                           .ToArray();
            char[] alphabet = new char[26];
            int letterNumber = 0;
            for (char i = 'a' ; i <='z'; i++)
            {
                alphabet[letterNumber] = i;
                letterNumber++;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for ( int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i]==alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", input[i],j);
                    }
                }
            }

            
        }
    }
}
