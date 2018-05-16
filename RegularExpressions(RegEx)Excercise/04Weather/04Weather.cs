using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([A-Z]{2})(\d{1,2}\.\d{0,2})([A-za-z]+)\|";
            Dictionary<string, KeyValuePair<double, string>> allData = new Dictionary<string, KeyValuePair<double, string>>();

            while (input != "end")
            {
                var matches = Regex.Matches(input, pattern);
                foreach (Match item in matches)
                {
                    if (!allData.ContainsKey(item.Groups[1].Value))
                    {
                        allData[item.Groups[1].Value] = new KeyValuePair<double, string>();

                    }
                    if (allData.ContainsKey(item.Groups[1].Value))
                    {
                        allData[item.Groups[1].Value] = new KeyValuePair<double, string>();
                    }
                    allData[item.Groups[1].Value] = new KeyValuePair<double, string>
                        (double.Parse(item.Groups[2].Value), item.Groups[3].Value);
                                      
                }
                input = Console.ReadLine();
            }

                var sortedData = allData.OrderBy(x => x.Value.Key);
                foreach (var item in sortedData)
                {
                    
                        Console.WriteLine("{0} => {1:f2} => {2}", item.Key, item.Value.Key, item.Value.Value);
                    
                }
            }
        }
    }


