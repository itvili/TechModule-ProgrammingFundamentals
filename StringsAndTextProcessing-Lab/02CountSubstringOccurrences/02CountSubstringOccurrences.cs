using System;

namespace _02CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int occurance = 0;
            int foundIndex = -1;

            for (int i = 0; i < text.Length; i++)
            {
                foundIndex = text.IndexOf(word, foundIndex+1);
                if (foundIndex==-1)
                {
                    break;
                }
                else
                {
                    occurance++;
                }
            }

            Console.WriteLine(occurance);
        }
    }
}
