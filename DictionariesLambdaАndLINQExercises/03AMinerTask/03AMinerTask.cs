using System;
using System.Collections.Generic;

namespace _03AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string, int> resourcesWithQuantities = new Dictionary<string, int>();

            int counterOddOrEven = 1;
            string resources = "";
            int quantities = 0;
            while (input!="stop")
            {
                if (counterOddOrEven%2==1)
                {
                    resources = input;
                }
                else
                {
                    quantities = int.Parse(input);
                }
                if(counterOddOrEven%2==0&&counterOddOrEven>=2)
                {
                    if (resourcesWithQuantities.ContainsKey(resources))
                    {
                        resourcesWithQuantities[resources]+=quantities;
                    }
                    else
                    {
                        resourcesWithQuantities[resources] = quantities;
                    }
                    
                }
                input = Console.ReadLine();
                counterOddOrEven++;
            }
            foreach (var item in resourcesWithQuantities)
            {
                Console.WriteLine("{0} -> {1}", item.Key,item.Value);
            }

            
        }
    }
}
