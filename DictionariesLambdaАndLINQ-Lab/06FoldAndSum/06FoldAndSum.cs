using System;
using System.Linq;

namespace _06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                  .Split(' ')
                  .Select(int.Parse)
                  .ToArray();

            int k = input.Length / 4;

            var firstRowLeftPart = input
                .Take(k)
                .Reverse()
                .ToArray();

            var firstRowRightPart = input
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = new int[2*k];

            Array.Copy(firstRowLeftPart, firstRow, firstRowLeftPart.Length);
            Array.Copy(firstRowRightPart, 0, firstRow, firstRowLeftPart.Length, firstRowRightPart.Length);



            var secondRow = input.Skip(k).Take(2 * k).ToArray();

            var sum = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
