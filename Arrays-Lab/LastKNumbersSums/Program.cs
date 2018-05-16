using System;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long sum = 0L;
            
            long[] sequence = new long[n];

            sequence[0] = 1;
            Console.Write("{0} ", sequence[0]);
            for (int i = 1; i < n; i++)
            {

                if (i<=k)
                {
                    sum = sum + sequence[(sequence.Length - 1) - (sequence.Length - i)];

                }
                else
                {
                    for (int j = i-k; j < i-1; j++)
                    {
                        sum = sum + sequence[j];
                    }
                }
                
                sequence[i] = sum;
                Console.Write("{0} ", sequence[i]);

            }


        }
    }
}
