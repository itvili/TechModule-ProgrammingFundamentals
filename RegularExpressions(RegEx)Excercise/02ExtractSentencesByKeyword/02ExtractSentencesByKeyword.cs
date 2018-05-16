using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] text = Console.ReadLine().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = $@"\b{word}\b";

            foreach (var seq in text)
            {
                var regex = Regex.Match(seq, pattern);

                if (regex.Success)
                {
                    Console.WriteLine(seq.Trim());
                }
            }
        }
    }
}
