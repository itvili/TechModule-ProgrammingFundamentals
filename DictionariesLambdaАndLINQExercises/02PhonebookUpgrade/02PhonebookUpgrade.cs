using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {

                    phonebook[input[1]] = input[2];

                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }
                else if (input[0]=="ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key,item.Value);
                    }
                }
                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}
