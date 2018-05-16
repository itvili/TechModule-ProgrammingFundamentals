using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            MatchCollection regex = Regex.Matches(text,pattern);
            //Regex regex1 = new Regex(pattern);

            var hexadecimal = regex.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", hexadecimal));


        }
    }
}
