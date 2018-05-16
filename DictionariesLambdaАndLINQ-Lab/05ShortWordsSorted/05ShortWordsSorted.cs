using System;
using System.Linq;

namespace _05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x=>x.Length<5)
                .OrderBy(x=>x)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", inputWords));


        }
    }
}
