using System;
using System.Linq;

namespace _03SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var instructionArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            input = input.Take(instructionArray[0]).ToList();
            input.RemoveRange(0, instructionArray[1]);

            int counterFindNumber = 0;
            foreach (var num in input)
            {
                if (num==instructionArray[2])
                {
                    counterFindNumber++;
                }
            }

            if (counterFindNumber>0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
