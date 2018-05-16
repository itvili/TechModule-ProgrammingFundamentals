using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_filled_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopRow(n);
            for (int i = 0;  i< n-2;i  ++)
            {
                PrintMiddleRow(n);
            } 

           
            PrintTopRow(n);

        }

        static void PrintTopRow(int n)
        {
            Console.WriteLine("{0}", new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
                      
                Console.Write('-');
                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    
  }

