using System;
using System.Linq;

namespace _03TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();
            string replasedText = String.Empty;
            for (int i = 0; i < bannedWords.Length; i++)
            {
                replasedText=text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                text = replasedText;
            }

            Console.WriteLine(replasedText);
        }
    }
}
