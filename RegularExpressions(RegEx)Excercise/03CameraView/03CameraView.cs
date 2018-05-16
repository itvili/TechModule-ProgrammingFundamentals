using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03CameraView
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int elementsToskip = int.Parse(input[0]);
            int elementsToTake = int.Parse(input[1]);
            string text = Console.ReadLine();
                        
            string pattern = "\\|<(\\w{"+ elementsToskip+"})(\\w{0,"+ elementsToTake +"})";

            var regex = Regex.Matches(text, pattern);
            List<string> output = new List<string>();
            foreach (Match item in regex)
            {
                output.Add(item.Groups[2].Value);
            }
            Console.Write(string.Join(", ", output));

        }
    }
}
