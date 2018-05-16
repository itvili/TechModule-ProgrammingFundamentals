using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = input.Length;

            int[] condensed = new int[input.Length - 1];
            if (input.Length == 1)
            {
                condensed = input;
            }
            else
            {
                for (int i = 0; i < length - 1; i++)
                {
                    condensed = new int[input.Length - 1];
                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        condensed[j] = input[j] + input[j + 1];
                    }

                    input = condensed;
                }
            }

            Console.WriteLine(string.Join(" ", condensed));
        }
    }
}
