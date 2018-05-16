using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                char needed = text[i];
                if (needed == Search)
                {
                    hasMatch = true;

                    int endIndex = jump+1;

                    
                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }
                    if (endIndex>text.Length-i)
                    {
                        endIndex = text.Length - i;
                    }

                   string matchedString = text.Substring(i, endIndex);

                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
