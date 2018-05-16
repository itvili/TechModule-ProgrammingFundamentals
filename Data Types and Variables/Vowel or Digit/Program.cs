using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            int num = 1;

            if (int.TryParse(symbol, out num))
            { 
                Console.WriteLine("digit");
            }
            else if (symbol=="a"|| symbol == "e"|| symbol == "i" || symbol == "o" || symbol == "u" || symbol == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
