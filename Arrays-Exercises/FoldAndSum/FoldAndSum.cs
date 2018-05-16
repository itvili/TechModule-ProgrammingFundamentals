using System;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            
            string[] arr = input.Split(' ');
                       
            arr = arr.Select(l => String.Join(" ", l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))).ToArray();
            //arr = arr.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            int[] arrInput = arr.Select(int.Parse).ToArray();

            int kCount = arrInput.Length / 4;
            int[] firstArr = new int[kCount];
            int[] secondArr = new int[kCount];
            int[] finalyArr = new int[arrInput.Length - 2 * kCount];

            for (int i = 0; i < kCount; i++)
            {
                firstArr[i] = arrInput[i];
                secondArr[i] = arrInput[(arr.Length - 1) - i];
            }

            firstArr = firstArr.Reverse().ToArray();

            Array.Copy(firstArr, finalyArr, firstArr.Length);
            Array.Copy(secondArr, 0, finalyArr, firstArr.Length, secondArr.Length);

            int[] middleArray = new int[2 * kCount];

            for (int i = 0; i < 2*kCount; i++)
            {
                middleArray[i] = arrInput[i + kCount];

            }

            int[] sumArray = new int[2 * kCount];

            for (int i = 0; i < kCount*2; i++)
            {
                sumArray[i] = finalyArr[i] + middleArray[i];

            }
            
            Console.WriteLine(string.Join(" ", sumArray));
                        
        }
    }
}
