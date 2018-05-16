using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '?', '!', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> palindrome = new List<string>();
            
            bool isPalindrome = true;
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                for (int j = 0; j < currentWord.Length/2; j++)
                {
                    if (currentWord[j]!=currentWord[currentWord.Length-1-j])
                    {
                        isPalindrome = false;
                    }
                    
                }
                if (isPalindrome==true)
                {
                    palindrome.Add(currentWord);
                }
                isPalindrome = true;
            }

            var orderedPalindrome = palindrome.Distinct().OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", orderedPalindrome));
        }

    }
}
    
    

