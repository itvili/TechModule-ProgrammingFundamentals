using System;
using System.Text.RegularExpressions;

namespace _05MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?\d+\.?\d*($|(?=\s))";

            var regex = Regex.Matches(input, pattern);

            foreach (Match item in regex)
            {
                Console.Write(item.Value+" ");
            }
        }
    }
}
