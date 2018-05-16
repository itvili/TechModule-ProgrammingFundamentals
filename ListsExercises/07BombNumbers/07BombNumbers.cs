using System;
using System.Collections.Generic;
using System.Linq;

namespace _07BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            long[] bomb = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            //Check for bomb number
           
                //Add zero before and after list to avoid Out of Range Exception
                for (int i = 0; i < bomb[1]; i++)
                {
                    input.Add(0);
                    input.Insert(0, 0);
                }

                //Remove all bombed numbers in range
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == bomb[0])
                    {
                        input.RemoveRange((int)(i - bomb[1]), (int)bomb[1] * 2 + 1);
                    i = 0;
                    }
                    
                }
                                
            
            //Sum all numbers
            long sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }

            Console.WriteLine(sum);
        }
    }
}
