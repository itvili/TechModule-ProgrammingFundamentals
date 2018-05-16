using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int counter = 0;
           
            for (int n1 = firstNumber; n1 <= secondNumber; n1++)
            {
                for (int n2 = firstNumber; n2 <= secondNumber; n2++)
                {
                    for (int n3 = firstNumber; n3 <=secondNumber; n3++)
                    {
                        for (int n4 = firstNumber; n4 <=secondNumber; n4++)
                        {
                            for (int n5 = firstNumber; n5 <= secondNumber; n5++)
                            {
                                if (n1<n2&&n2<n3&&n3<n4&&n4<n5)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    counter++;
                                }
                                                                    
                            }
                        }
                    }
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
