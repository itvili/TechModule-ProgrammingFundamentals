using System;
using System.Collections.Generic;
using System.Text;

namespace _03UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            List<string> unicode = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string escape = "\\u" + ((int)text[i]).ToString("x").PadLeft(4, '0');

                unicode.Add(escape);
            }

            Console.WriteLine(string.Join("",unicode));
        }
    }
}
