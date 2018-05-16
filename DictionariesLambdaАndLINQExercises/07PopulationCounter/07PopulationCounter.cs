using System;
using System.Collections.Generic;
using System.Linq;

namespace _07PopulationCounter
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();
            string country ="";
            string city = "";
            long populationPerCity = 0;


            Dictionary<string, Dictionary<string, long>> countriesAndCitiesPopulation = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> countryPopulation = new Dictionary<string, long>();

            while (city!="report")
            {
                city = input[0];
                if (city=="report")
                {
                    break;
                }
                country = input[1];

                populationPerCity = long.Parse(input[2]);

                if (!countriesAndCitiesPopulation.ContainsKey(country))
                {
                    countriesAndCitiesPopulation[country] = new Dictionary<string, long>();
                }
                
                countriesAndCitiesPopulation[country][city] = populationPerCity;

                input = Console.ReadLine().Split('|').ToList();
            }

            long sumPopulation = 0;
            foreach (var countryName in countriesAndCitiesPopulation)
            {
                var population = countryName.Value;
                foreach (var cityAndPop in population)
                {
                    sumPopulation += cityAndPop.Value;
                }
                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation[countryName.Key] = sumPopulation;
                }
                countryPopulation[countryName.Key] = sumPopulation;
                sumPopulation = 0;
            }

            foreach (var countryNames in countryPopulation.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine("{0} (total population: {1})", countryNames.Key, countryNames.Value);
                foreach (var item in countriesAndCitiesPopulation)
                {
                    var cityPopulation = item.Value;
                    if (countryNames.Key == item.Key)
                    {
                        foreach (var cityIndividual in cityPopulation.OrderByDescending(x=>x.Value))
                        {
                            Console.WriteLine("=>{0}: {1}", cityIndividual.Key,cityIndividual.Value);
                        }

                       
                    }
                }
                
            }

        }
    }
}
