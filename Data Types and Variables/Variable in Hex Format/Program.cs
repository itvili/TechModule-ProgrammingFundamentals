using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            long convertedInteger = Convert.ToInt64(hexadecimal, 16);

            Console.WriteLine(convertedInteger);
        }
    }
}
