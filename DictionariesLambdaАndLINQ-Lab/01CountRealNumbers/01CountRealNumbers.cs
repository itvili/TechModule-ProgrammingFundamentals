using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> countRealNumbers = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (countRealNumbers.ContainsKey(num))
                {
                    countRealNumbers[num]=countRealNumbers[num]+1;
                }
                else
                {
                    countRealNumbers[num] = 1;
                }
                              
            }
            foreach (var num in countRealNumbers.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, countRealNumbers[num]);
            }
        }
    }
}
