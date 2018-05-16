using System;
using System.Collections.Generic;
using System.Linq;

namespace _06UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = Console.ReadLine().Split(' ').ToList();

            SortedDictionary<string, Dictionary<string, List<string>>> usersActivities
           = new SortedDictionary<string, Dictionary<string, List<string>>>();

            Dictionary<string, List<string>> ipAdressesAndMessages = new Dictionary<string, List<string>>();
            while (inputData[0] != "end")
            {
                string user = inputData[2].Substring(5, inputData[2].Length - 5);
                string ipAdress = inputData[0].Substring(3, inputData[0].Length - 3);
                string message = inputData[1].Substring(8, inputData[1].Length - 8).ToString();

               

                if (!usersActivities.ContainsKey(user))
                {
                    usersActivities[user]= new Dictionary<string, List<string>>();

                }
                if (!usersActivities[user].ContainsKey(ipAdress))
                {
                   usersActivities[user][ipAdress] = new List<string>();
                }
                usersActivities[user][ipAdress].Add(message);

                inputData = Console.ReadLine().Split(' ').ToList();
                
            }
            int counter = 0;
            foreach (var userName in usersActivities)
            {
                var innerDict = userName.Value;
                Console.WriteLine("{0}:", userName.Key);

                
                foreach (var ipMessages in innerDict)
                {
                    counter++;
                    var countOfmessages = (ipMessages.Value).Count;
                    if (counter==innerDict.Count)
                    {
                        Console.Write("{0} => {1}. ", ipMessages.Key, countOfmessages);
                        Console.WriteLine();
                        
                    }
                    else
                    {
                        Console.Write("{0} => {1}, ", ipMessages.Key, countOfmessages);
                    }
                    
                }
                counter = 0;
                                             
            }
        }
    }
}
