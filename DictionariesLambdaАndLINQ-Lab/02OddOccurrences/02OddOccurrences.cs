using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        private static object countWords;

        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            Dictionary<string, int> countsWords = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (countsWords.ContainsKey(word))
                {
                    countsWords[word]++;
                }
                else
                {
                    countsWords[word] = 1;
                }
            }

            var result = new List<string>();
            foreach (var count in countsWords)
            {
                if (count.Value % 2 == 1)
                {
                    result.Add(count.Key);
                }
            }


            Console.WriteLine(string.Join(", ",result));

        }
    }
}
