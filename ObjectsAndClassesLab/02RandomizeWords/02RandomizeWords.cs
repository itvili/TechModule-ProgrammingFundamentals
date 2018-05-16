using System;
using System.Linq;

namespace _02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Random rnd = new Random();
                var random = rnd.Next(0, input.Length - 1);

                var tempI = input[i];
                input[i] = input[random];
                input[random] = tempI;
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
