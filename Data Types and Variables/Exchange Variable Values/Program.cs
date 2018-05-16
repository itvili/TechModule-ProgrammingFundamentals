using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:"+Environment.NewLine +"a = {0}"+Environment.NewLine+"b = {1}", a,b);

            int temporary = a;
            a=b;
            b = temporary;
            Console.WriteLine("After:" + Environment.NewLine + "a = {0}" + Environment.NewLine + "b = {1}", a, b);
                    
        }
    }
}
