using System;
using System.Collections.Generic;

namespace _04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, string> namesAndEmails = new Dictionary<string, string>();

            string name = "";
            string email = "";
            int counterOddOrEvenLoop = 1;

            while (input!="stop")
            {
                if (counterOddOrEvenLoop%2==1)
                {
                    name = input;
                }
                else
                {
                    email = input;
                }
                if (counterOddOrEvenLoop%2==0 &&counterOddOrEvenLoop>=2)
                {
                    namesAndEmails[name] = email;
                }

                counterOddOrEvenLoop++;
                input = Console.ReadLine();
            }

            foreach (var item in namesAndEmails)
            {
                if (item.Value.EndsWith("us") || item.Value.EndsWith("uk"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }

            }
            
        }

    }
}
