using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            char lines = '|';
            char dotes = '.';
            int brDotesHealth = maxHealth - currentHealth;
            int brDotesEnergy = maxEnergy - currentEnergy;
            Console.WriteLine($"Name: {name}"+ Environment.NewLine+
                              "Health: |{0}{1}|" +Environment.NewLine+
                              "Energy: |{2}{3}|", new string(lines, currentHealth), new string(dotes, brDotesHealth), 
                                                   new string(lines,currentEnergy), new string(dotes,brDotesEnergy));


        }
    }
}
