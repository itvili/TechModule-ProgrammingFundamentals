using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_by_Word_Casing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {

                string symbolType = input[i];
                if (symbolType.All(Char.IsLower))
                {
                    lowerCaseWords.Add(input[i]);
                }
                else if (symbolType.All(Char.IsUpper))
                {
                    upperCaseWords.Add(input[i]);
                }
                else
                {
                    mixedCaseWords.Add(input[i]);
                }
            }

            Console.WriteLine("Lower-case: "+String.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCaseWords));


        }
    }
}
