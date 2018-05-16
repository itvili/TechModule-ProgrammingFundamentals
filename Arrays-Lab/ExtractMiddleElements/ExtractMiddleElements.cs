using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            if (input.Length==1)
            {
                Console.WriteLine(string.Join("", input));
            }
            else if (input.Length%2==0)
            {
                
                Console.WriteLine("{ "+ String.Join(", ", input[(input.Length - 1) / 2], input[(input.Length - 1) / 2 + 1])+" }");
            }
            else
            {
               Console.WriteLine("{ " + String.Join(", ", input[((input.Length) / 2)-1], input[(input.Length) / 2], input[(input.Length) / 2 + 1]) + " }");
            }
                
        }
    }
}
