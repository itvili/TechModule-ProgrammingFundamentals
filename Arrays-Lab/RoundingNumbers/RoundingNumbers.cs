using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < seq.Length; i++)
            {
                double number = seq[i];

                Console.WriteLine("{0} => {1} ",number, Math.Round(number,MidpointRounding.AwayFromZero));
            }
        }
    }
}
