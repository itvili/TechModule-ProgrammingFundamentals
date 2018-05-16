using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split('|').Reverse()
            //    .Select(x => x.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries))));

            var input = Console.ReadLine().Split('|').ToList();

            List<string> finalyList = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                string[] curentString = input[i].Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                finalyList.AddRange(curentString);
                //for (int j = 0; j < curentString.Length; j++)
                //{
                //    finalyList.Add(curentString[j]);
                //}
            }

            Console.Write(string.Join(" ", finalyList));
        }
    }
}
