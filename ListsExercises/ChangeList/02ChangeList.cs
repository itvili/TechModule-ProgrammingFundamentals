using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var commands = Console.ReadLine().ToLower().Split(' ').ToArray();
            while (commands[0] != "odd" && commands[0]!="even")
            {
             
                switch(commands[0])
                {
                    case "delete":
                        input.RemoveAll(item=>item==long.Parse(commands[1]));
                        break;
                    case "insert":
                        input.Insert(int.Parse(commands[2]), long.Parse(commands[1]));
                        break;
                  
                }
                commands = Console.ReadLine().ToLower().Split(' ').ToArray();
                
            }
            if (commands[0] == "even")
            {
                GetEven(input);
            }
            else if (commands[0] == "odd")
            {
                GetOdd(input);
            }


        }

        static void GetEven(List<long> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]%2==0)
                {
                    Console.Write("{0} ",input[i]);
                }
            }
        }
        static void GetOdd(List<long> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    Console.Write("{0} ",input[i]);
                }
            }
        }
    }
}
