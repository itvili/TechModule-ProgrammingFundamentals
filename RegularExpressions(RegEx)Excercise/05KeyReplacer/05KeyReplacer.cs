using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"^([A-za-z]+)([<\|\\]{1}.+[<\|\\]{1})([A-Za-z]+)$";

            var regex = Regex.Matches(keys, pattern);
            string startKey = "";
            string endKey = "";
            foreach (Match item in regex)
            {
                startKey = item.Groups[1].Value;
               endKey = item.Groups[3].Value;
            }

            string patternToGetWords = $@"({startKey})(?!{endKey})(.*?)({endKey})";
            var words = Regex.Matches(text, patternToGetWords);

            if (words.Count>0)
            {
                foreach (Match item in words)
                {
                    Console.Write(item.Groups[2].Value);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty result");
            }
            
        }
    }
}
