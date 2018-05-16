using System;
using System.Linq;

namespace _04CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            char[] firstWord = words[0].ToCharArray();
            char[] secondWord = words[1].ToCharArray();

            int length = Math.Min(words[0].Length, words[1].Length);
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < length; i++)
            {
                sum += firstWord[i] * secondWord[i];
                counter++;
            }
            if (firstWord.Length==1)
            {
               GetSumFrom1CharWord(firstWord, secondWord, out sum, out counter);
            }
            else if(secondWord.Length==1)
            {
                GetSumFrom1CharWord(secondWord, firstWord, out sum, out counter);
            }
            if (firstWord.Length > secondWord.Length)
            {
                sum = GetSum(firstWord, length, sum, counter);
            }
            else if(secondWord.Length>firstWord.Length)
            {
                sum = GetSum(secondWord, length, sum, counter);

            }
            Console.WriteLine(sum);

        }

        private static void GetSumFrom1CharWord(char[] firstWord, char[] secondWord, out int sum, out int counter)
        {
            sum = firstWord[0] * secondWord[0];
            counter = 1;
        }

        private static int GetSum(char[] firstWord, int length, int sum, int counter)
        {
            for (int i = counter; i <firstWord.Length; i++)
            {
                sum += firstWord[i];
            }
           return sum;
        }
    }
}
