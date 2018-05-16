using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new[] { '?', '&' },StringSplitOptions.RemoveEmptyEntries).ToArray() ;
            string pattern = @"\b(.+?)=(.+)";
            List<string> pairs = new List<string>();
            Dictionary<string, List<string>> keysValues = new Dictionary<string, List<string>>();

            while (input[0] != "END")
            {

                for (int i = 0; i < input.Length; i++)
                {
                    var regex = Regex.Match(input[i], pattern);

                    pairs.Add(regex.Value);
                }
                string patternReplace = @"((\+|%20)+)";

                List<string> pairsWithoutSpaces = new List<string>();

                foreach (var item in pairs)
                {
                    var regexUserAndValue = Regex.Replace(item, patternReplace, " ");
                    pairsWithoutSpaces.Add(regexUserAndValue);
                }
                string key = "";
                string value = "";


                for (int i = 0; i < pairsWithoutSpaces.Count; i++)
                {
                    var regexKeyValue = Regex.Matches(pairsWithoutSpaces[i], pattern);
                    foreach (Match item in regexKeyValue)
                    {
                        key = item.Groups[1].Value.Trim();
                        value = item.Groups[2].Value.Trim();

                        if (!keysValues.ContainsKey(key))
                        {
                            keysValues[key] = new List<string>();
                        }
                        keysValues[key].Add(value);
                    }


                }
                foreach (var item in keysValues)
                {
                    Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
                }
                Console.WriteLine();

                keysValues.Clear();
                pairsWithoutSpaces.Clear();
                pairs.Clear();
                input = Console.ReadLine().Split(new[] { '?', '&' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                
            }
        }
    }
}
