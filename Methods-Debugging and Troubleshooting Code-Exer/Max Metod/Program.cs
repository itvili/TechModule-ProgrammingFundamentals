using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (thirdNumber>=GetMax(firstNumber,secondNumber))
            {
                Console.WriteLine(thirdNumber);
            }
            else
            {
                Console.WriteLine(GetMax(firstNumber,secondNumber));
            }

        }
        static int GetMax(int first,int second)
        {
            if (first>=second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
