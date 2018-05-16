using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            string pattern = @"\b([a-zA-Z][\w]{2,24})\b";
            List<string> users = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var usernames = Regex.Matches(input[i], pattern);
                foreach (Match item in usernames)
                {
                    users.Add(item.Groups[1].Value);
                }
            }
            
            int maxSumofLenght = 0;
            
            int curentSumOfLenght = 0;
            
            string firstMaxWord = "";
            string secondMaxWord = "";
                       

            for (int i = 0; i < users.Count-1; i++)
            {
               curentSumOfLenght= users[i].Length + users[i + 1].Length;
                if (curentSumOfLenght>maxSumofLenght)
                {
                    maxSumofLenght = curentSumOfLenght;
                    firstMaxWord = users[i];
                    secondMaxWord = users[i + 1];
                }
            }

           
            Console.WriteLine(firstMaxWord);
            Console.WriteLine(secondMaxWord);
        }
    }
}
