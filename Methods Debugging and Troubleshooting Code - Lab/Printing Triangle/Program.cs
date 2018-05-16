using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
            //PrintLine(1, n);

            for (int i = n; i >= 0; i--)
            {
                PrintLine(1, i);
            }


        }
        static void PrintLine(int start, int end)
        {
            for (int col = start; col <= end; col++)
            {

                Console.Write("{0} ", col);
            }
            Console.WriteLine();
        }

    }
}

