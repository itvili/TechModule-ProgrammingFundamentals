using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double eps = Math.Abs(number1-number2);
            string equals="";
            if (eps<0.000001)
            {
                equals = "True";
            }
            else
            {
                equals = "False";
            }
            Console.WriteLine(equals);


        }
    }
}
