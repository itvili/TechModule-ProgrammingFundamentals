using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyTotal = (double)volume * energy / 100;
            double sugarTotal = (double)volume * sugar / 100;

            Console.WriteLine($"{volume}ml {name}:"+Environment.NewLine+$"{energyTotal}kcal, {sugarTotal}g sugars");


        }
    }
}
