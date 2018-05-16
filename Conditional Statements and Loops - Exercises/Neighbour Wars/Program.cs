using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int healthPesho=100;
            int healthGosho=100;
            int counter = -1;


            for (int i = 1; i <=100; i++)
            {
                counter++;
                if (healthPesho<=0)
                {
                    Console.WriteLine($"Gosho won in {counter}th round.");
                    return;
                }
                if (healthGosho <= 0)
                {
                    Console.WriteLine($"Pesho won in {counter}th round.");
                    return;
                }
                   
                if (i%2==1)
                {
                    healthGosho -= damagePesho;
                    if (healthGosho>0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                else
                {
                    healthPesho-= damageGosho;
                    if (healthPesho>0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }
                    else
                    {
                        continue;
                    }
                    
                }

                if (i%3==0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }

               
            }

        }
    }
}
