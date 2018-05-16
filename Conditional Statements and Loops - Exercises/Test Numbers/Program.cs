using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int counter = 0;

            for (int first = n; first >=1; first--)
            {
                for (int second = 1; second <=m; second++)
                {
                    int sum = (first * second) * 3;
                    totalSum+= sum;
                    counter++;
                    if (totalSum>=controlNumber)
                    {
                        Console.WriteLine($"{counter} combinations"+Environment.NewLine
                                         +$"Sum: {totalSum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations" + Environment.NewLine
                                         + $"Sum: {totalSum}");
        }
    }
}
