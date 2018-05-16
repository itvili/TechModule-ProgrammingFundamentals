using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonachiNumber(number));

        }
        static int GetFibonachiNumber(int number)
        {
            int firstNumber = 0;
            int fibonachiNumber=1;
            for (int i = 0; i < number; i++)
            {
                int temp = firstNumber;
                firstNumber = fibonachiNumber;
                fibonachiNumber =temp+ fibonachiNumber;
                
            }
            return fibonachiNumber;
        }
    }
}
