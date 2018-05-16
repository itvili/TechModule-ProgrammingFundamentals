using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            string lastDigit = Convert.ToString(number % 10);
            Console.WriteLine(PrintEnglishName(lastDigit));
            
        }
        static string PrintEnglishName(string lastDigit)
        {
            switch (lastDigit)
            {
                case "0":
                    return "zero";
                case "1":
                    return "one";
                case "2":
                    return "two";
                case "3":
                    return "three";
                case "4":
                    return "four";
                case "5":
                    return "five";
                case "6":
                    return "six";
                case "7":
                    return "seven";
                case "8":
                    return "eight";
                default:
                    return "nine";
            }
           
        }
    }
}
