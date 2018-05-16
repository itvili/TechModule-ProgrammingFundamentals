using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {



            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
          

            List<double> result = new List<double>();
            result = input;
            double sum = 0.0;
            bool IsEquals = true;

            while (true)
            {
                IsEquals = false;
                for (int i = 0; i < result.Count - 1; i++)
                {

                    if (result[i] == result[i + 1])
                    {
                        sum = result[i] + result[i + 1];
                    result.RemoveRange(i, 2);

                    result.Insert(i, sum);

                       IsEquals = true;
                    }
                }
                if (!IsEquals)
                {
                    break;
                }

            }

            Console.WriteLine(String.Join(" ", result));
            }

        }
        
    }

