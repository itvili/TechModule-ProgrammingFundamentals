using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08UseYourChanceBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string patternGetPTag = @"<p>(.+?)<\/p>";

            string input = Console.ReadLine();


            var regexGetPtag = Regex.Matches(input, patternGetPTag);

            List<string> pTag = new List<string>();

            foreach (Match item in regexGetPtag)
            {
                pTag.Add(item.Groups[1].Value);
            }
            //@"([\W]+?)+"
            string patternReplaceNowordSymbol = @"[^a-z0-9]+";

            StringBuilder replacedNonWordSymbol = new StringBuilder();

            for (int i = 0; i < pTag.Count; i++)
            {
                string replacer = Regex.Replace(pTag[i], patternReplaceNowordSymbol, " ");

                replacedNonWordSymbol.Append(replacer);
            }


            for (int i = 0; i < replacedNonWordSymbol.Length; i++)
            {
                if ('a' <= replacedNonWordSymbol[i] && replacedNonWordSymbol[i] <= 'm')
                {
                    replacedNonWordSymbol[i] = (char)(replacedNonWordSymbol[i] + 13);
                }
                else if ('n' <= replacedNonWordSymbol[i] && replacedNonWordSymbol[i] <= 'z')
                {
                    replacedNonWordSymbol[i] = (char)(replacedNonWordSymbol[i] - 13);
                }
                else
                {

                }
            }

            Console.WriteLine(replacedNonWordSymbol);


        }
    }
}
