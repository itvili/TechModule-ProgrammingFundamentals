using System;
using System.Collections.Generic;
using System.Linq;

namespace _08LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrderedLines = int.Parse(Console.ReadLine());
            

            Dictionary<string, Dictionary<string, int>> userActivity = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < countOfOrderedLines; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                string name = input[1];
                string ipAdress = input[0];
                int duration = int.Parse(input[2]);

                if (!userActivity.ContainsKey(name))
                {
                    userActivity[name] = new Dictionary<string, int>();
                }
                if (!userActivity[name].ContainsKey(ipAdress))
                {
                    userActivity[name][ipAdress] = duration;
                }
                else
                {
                    userActivity[name][ipAdress] += duration;
                }
            }
            long sum = 0;
            //foreach (var user in userActivity.OrderBy(x => x.Key))
            //{
            //    Console.Write("{0}: ", user.Key);
            //    var ipAndduration = user.Value;
            //    foreach (var item in ipAndduration)
            //    {
            //        sum += item.Value;

            //    }
            //    Console.Write($"{sum} " + "[" + string.Join(", ", ipAndduration.Keys) + "]");
            //    sum = 0;
            //    Console.WriteLine();
            ////}
            //sum = 0;

            foreach (var item in userActivity.OrderBy(x => x.Key))
            {
                List<string> ipAdresses = item.Value.Select(x => x.Key).OrderBy(x=>x).ToList();
                sum = item.Value.Select(x => x.Value).Sum();
                Console.WriteLine($"{item.Key}: {sum} ["+string.Join(", ",ipAdresses)+"]");

            }


        }
    }
}
