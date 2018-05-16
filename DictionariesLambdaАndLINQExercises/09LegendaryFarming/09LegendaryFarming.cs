using System;
using System.Collections.Generic;
using System.Linq;

namespace _09LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            
            
            int legendaryNeeded = 0;
            string legendaryName = "";
            string legendaryMaterial = "";
            
            
            int materialQuantity = 0;
            string materialType = "";


            Dictionary<string, int> legendaryMaterialsQuantity = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterialsQuantity = new Dictionary<string, int>();

            while (legendaryNeeded<250)
            {
                var materials = Console.ReadLine().ToLower().Split(' ').ToList();
                

                for (int i = 0; i < materials.Count-1; i+=2)
                {
                    if (legendaryNeeded >= 250)
                    {
                        break;
                    }
                    materialQuantity = int.Parse(materials[i]);
                        materialType = materials[i + 1];

                    switch (materialType)
                    {
                        case "shards":
                        case "fragments":
                        case "motes":
                            if (!legendaryMaterialsQuantity.ContainsKey(materialType))
                            {
                                legendaryMaterialsQuantity[materialType] = materialQuantity;
                            }
                            else
                            {
                                legendaryMaterialsQuantity[materialType] += materialQuantity;
                            }
                            break;
                        default:
                            if (!junkMaterialsQuantity.ContainsKey(materialType))
                            {
                                junkMaterialsQuantity[materialType] = materialQuantity;
                            }
                            else
                            {
                                junkMaterialsQuantity[materialType] += materialQuantity;
                            }
                            break;
                    }
                    foreach (var item in legendaryMaterialsQuantity)
                    {


                        if (item.Value >= 250)
                        {
                            legendaryNeeded = item.Value;
                            switch (item.Key)
                            {
                                case "shards":
                                    legendaryName = "Shadowmourne";
                                    legendaryMaterial = item.Key;

                                    break;
                                case "fragments":
                                    legendaryName = "Valanyr";
                                    legendaryMaterial = item.Key;
                                    break;
                                case "motes":
                                    legendaryName = "Dragonwrath";
                                    legendaryMaterial = item.Key;
                                    break;
                                default:
                                    continue;

                            }
                        }
                    }
                }
            }
            
            Console.WriteLine("{0} obtained!",legendaryName);
            Dictionary<string, int> outputLegendaryMaterialsAndQuantity = new Dictionary<string, int>();

            foreach (var item in legendaryMaterialsQuantity)
            {
                if (item.Key.Contains(legendaryMaterial))
                {
                    outputLegendaryMaterialsAndQuantity[item.Key] = item.Value - 250;
                }
                else
                {
                    outputLegendaryMaterialsAndQuantity[item.Key] = item.Value;
                }
                if (!legendaryMaterialsQuantity.Keys.Contains("fragments"))
                {
                    outputLegendaryMaterialsAndQuantity["fragments"] = 0;
                }
                if (!legendaryMaterialsQuantity.Keys.Contains("shards"))
                {
                    outputLegendaryMaterialsAndQuantity["shards"] = 0;
                }
                if (!legendaryMaterialsQuantity.Keys.Contains("motes"))
                {
                    outputLegendaryMaterialsAndQuantity["motes"] = 0;
                }

            }

           
            foreach (var item in outputLegendaryMaterialsAndQuantity.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key,item.Value);
            }
            foreach (var item in junkMaterialsQuantity.OrderBy(x=>x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
