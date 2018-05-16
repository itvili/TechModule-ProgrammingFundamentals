using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int counterMagic = 0;
            int counterCombinations = 0;

            for (int first = n; first <=m ; first++)
            {
                for (int second = n; second <=m; second++)
                {
                    
                    if (first+second==magicalNumber)
                    {
                        Console.WriteLine($"Number found! {second} + {first} = {magicalNumber}");
                        counterMagic++;
                        return;
                    }
                    counterCombinations++;
                }
            }
            
                Console.WriteLine($"{counterCombinations} combinations - neither equals {magicalNumber}");
            
        }
    }
}
