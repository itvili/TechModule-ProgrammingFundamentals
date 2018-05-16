using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPhones = Console.ReadLine();
           
                string pattern = @"(\+359[ ]?2[ ]?[\d]{3}[ ]?[\d]{4})|\+359[-]?2[-]?[\d]{3}[-]?[\d]{4}";

            MatchCollection regex = Regex.Matches(inputPhones, pattern);

            List<string> phones = new List<string>();

                foreach (Match m in regex)
                {
                    phones.Add(m.Value);
                }

            Console.Write(string.Join(", ", phones));
            Console.WriteLine();

            //    LINQ
            //    var matchedPhones = regex.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
        }
    }
}
