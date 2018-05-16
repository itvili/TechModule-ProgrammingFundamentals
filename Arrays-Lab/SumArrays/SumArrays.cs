using System;
using System.Linq;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] output = new int[Math.Max(input1.Length, input2.Length)];

            int[] finalyInput = new int[Math.Max(input1.Length, input2.Length)];
            int number = 0;
            int j = 0;
            var length = Math.Max(input1.Length, input2.Length);

            for (int i = 0; i <length; i++)
            {
                if (input1.Length>input2.Length)
                {
                    foreach (var item in input2)
                    {
                        number = item;
                        finalyInput[j] = number;
                        
                        if (j==length-1)
                        {
                            break;
                        }
                        j++;
                    }
                    
                }
                if (input1.Length < input2.Length)
                {
                    foreach (var item in input1)
                    {
                        if (j == length)
                        {
                            break;
                        }
                        number = item;
                        finalyInput[j] = number;
                                               
                        j++;
                    }

                }
               
            }

            for (int i = 0; i < length; i++)
            {
                if (input2.Length<input1.Length)
                {
                    output[i] = finalyInput[i] + input1[i];
                }
                else if(input2.Length > input1.Length)
                {
                    output[i] = finalyInput[i] + input2[i];
                }
                else
                {
                    output[i] = input1[i] + input2[i];
                }
                
            }
            //Console.Write(string.Join(" ", finalyInput));
            //Console.WriteLine();

            Console.Write(string.Join(" ", output));
            Console.WriteLine();
        }
    }
}
