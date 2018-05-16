using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotation = int.Parse(Console.ReadLine());
            int[] tempArr = new int[input.Length];
            int[] newArr = new int[input.Length];
            int[] sum = new int[input.Length];


            for (int j = 1; j <= numberOfRotation; j++)
            {


                for (int i = 0; i < input.Length; i++)
                {
                    //newArr[i] = input[(i + 1) % input.Length]; Left rotated
                    newArr[(i + j) % newArr.Length] = input[i];
                    tempArr = newArr;
                    sum[(i + j) % newArr.Length] = sum[(i + j) % newArr.Length] + tempArr[(i + j) % newArr.Length];
                }
               
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
