using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long a;
            long b;
            bool isSum=false;
            long sum=0L;
            long counter = 0;
            long tempA = 0L;
            long tempB = 0L;
            long tempSum = 0L;
            for (long i = 0; i <= seq.Length-1; i++)
            {
                for (long j = 0; j <= seq.Length-1; j++)
                {
                    a = seq[i];
                    b = seq[j];
                    bool isFirst = i<j;

                    
                    foreach (var item in seq)
                    {
                        isSum = a + b == item;
                        sum = item;
                        if (isFirst && isSum)
                        {
                            Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                            counter++;
                            tempA = a;
                            tempB = b;
                            tempSum = sum;
                            if (tempA==a&&tempB==b&&tempSum==sum)
                            {
                                break;
                            }
                        }
                        
                    }
             
                }
            }

            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
