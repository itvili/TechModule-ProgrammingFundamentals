using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {


            string ingredients = "";
            int countIngredinets = 0;
            while (ingredients!="Bake!")
            {
                ingredients = Console.ReadLine();
                if (ingredients == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", countIngredinets);
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.", ingredients);
                countIngredinets++;
            }
            
        }
    }
}
