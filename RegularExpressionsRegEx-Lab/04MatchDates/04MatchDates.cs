using System;
using System.Text.RegularExpressions;


namespace _04MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<days>[\d]{2})([\/.\-])(?<months>[A-Z][a-z]{2})\1(?<years>[\d]{4})\b";

            //Regex regex = new Regex(pattern);

            var dates = Regex.Matches(input,pattern);
            

            foreach (Match date in dates)
            {
                var day = date.Groups["days"].Value;
                var month = date.Groups["months"].Value;
                var year = date.Groups["years"].Value;
                
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", day, month, year);
            }
        }
    }
}
