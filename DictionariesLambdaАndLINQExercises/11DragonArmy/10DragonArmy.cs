using System;
using System.Collections.Generic;
using System.Linq;

namespace _11DragonArmy
{
    class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int[]>> dragonsTypeAndStats
                = new Dictionary<string, Dictionary<string, int[]>>();
            string type = "";
            string name = "";
            bool damage = true;
            bool health = true;
            bool armor =true;


            for (int i = 0; i < numberOfLines; i++)
            {
                var inputDragons = Console.ReadLine().Split(' ').ToList();
                type = inputDragons[0];
                name = inputDragons[1];
                int resultDamage = 0;
                int resultHealth = 0;
                int resultArmor = 0;

                damage = int.TryParse(inputDragons[2], out resultDamage);
                health = int.TryParse(inputDragons[3], out resultHealth);
                armor = int.TryParse(inputDragons[4], out resultArmor);
                if (!damage)
                {
                    resultDamage = 45;

                }
                if (!health)
                {
                    resultHealth = 250;

                }
                if (!armor)
                {
                    resultArmor = 10;

                }

                if (!dragonsTypeAndStats.ContainsKey(type))
                {
                    dragonsTypeAndStats[type] = new Dictionary<string, int[]>();
                }
                if (!dragonsTypeAndStats[type].ContainsKey(name))
                {
                    dragonsTypeAndStats[type][name] = new int[3];
                }
                dragonsTypeAndStats[type][name][0]=resultDamage;
                dragonsTypeAndStats[type][name][1]= resultHealth;
                dragonsTypeAndStats[type][name][2] = resultArmor;

                      
            }
            

            foreach (var item in dragonsTypeAndStats)
            {
                var dragonNames = item.Value;
                
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})",
                    item.Key, item.Value.Select(x=>x.Value[0]).Average(), 
                    dragonNames.Select(x=>x.Value[1]).Average(), 
                    dragonNames.Select(x=>x.Value[2]).Average());
              
                foreach (var dragonName in dragonNames.OrderBy(x => x.Key))
                {

                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                        dragonName.Key, dragonName.Value[0], dragonName.Value[1],dragonName.Value[2]);
                }
            }
        }
    }
}
