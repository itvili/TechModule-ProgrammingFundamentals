﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=N-AlTemCnMc&t=24m55s
            //https://softuni.bg/forum/9168/list-homework-largest-increasing-subsequence

            var sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            var longestSeq = FindLongestIncreasingSubsequence(sequence);
            //Console.WriteLine("Longest increasing subsequence (LIS)");
            //   Console.WriteLine("  Length: {0}", longestSeq.Length);
            Console.WriteLine(string.Join(" ", longestSeq));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] sequence)
        {
            int[] length = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            var longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(sequence[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
