using System;
using System.Text.RegularExpressions;

namespace _06ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";

            while (input!="end")
            {
                string replaced = Regex.Replace(input, pattern, replace);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }

           

        }
    }
}
