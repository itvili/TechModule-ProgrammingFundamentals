using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(NumberReversedOrder(number));

        }
        static string NumberReversedOrder(string number)
        {
                string reversedNumber= "";
                int symbol = number.Length - 1;

            for (int i = 0; i <= number.Length-1; i++)
            {
                char textNumber = number[symbol];
                symbol--;
               
                reversedNumber= reversedNumber+ textNumber;
            }

            return reversedNumber;
        }
    }
}
