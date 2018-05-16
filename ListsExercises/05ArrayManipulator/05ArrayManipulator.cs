using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string[] commands = Console.ReadLine().Split(' ').ToArray();
           

            while (commands[0]!="print")
            {
                switch (commands[0])
                {
                    case "add":

                        int index = int.Parse(commands[1]);
                        long element = long.Parse(commands[2]);
                        input.Insert(index, element);
                        break;

                    case "addMany":
                        int indexAddMany = int.Parse(commands[1]);
                        var elementMany = commands.Skip(2).ToArray();
                        List<long> elementToInsert = new List<long>();
                        for (int i = 0; i < elementMany.Length; i++)
                        {
                            elementToInsert.Add(long.Parse(elementMany[i]));
                        }
                        input.InsertRange(indexAddMany, elementToInsert);

                        break;

                    case "contains":
                        long containsElement = 0;
                        containsElement = input.IndexOf(long.Parse(commands[1]));

                        Console.WriteLine(containsElement);
                        break;

                    case "remove":
                        input.RemoveAt(int.Parse(commands[1]));
                        break;

                    case "shift":

                        int positions = int.Parse(commands[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            long lastElement = input[0];
                            for (int j = 0; j < input.Count - 1; j++)
                            {
                                input[j] = input[j + 1];
                            }
                            input[input.Count - 1] = lastElement;
                        }
                        break;

                    case "sumPairs":
                        List<long> newInput = new List<long>();
                        for (int i = 1; i < input.Count; i += 2)
                        {
                            newInput.Add(input[i] + input[i - 1]);

                        }
                        if (input.Count % 2 == 0)
                        {
                            input = newInput;
                        }
                        else
                        {
                            newInput.Add(input[input.Count - 1]);
                            input = newInput;
                        }

                        break;

                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }
    }
}
