using System;
using System.Linq;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstrow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondrow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            CompareChar(firstrow, secondrow);
        } 

        static void CompareChar(char[] firstRow, char[] secondRow)
        {

            int maxLenght = Math.Max(firstRow.Length, secondRow.Length);
            int minLenght = Math.Min(firstRow.Length, secondRow.Length);
            int counter = 0;


                if (firstRow[0] < secondRow[0])
                {
                    Console.WriteLine(String.Join("", firstRow));
                    Console.WriteLine(String.Join("", secondRow));
                }

                else if (firstRow[0] > secondRow[0])
                {
                    Console.WriteLine(String.Join("", secondRow));
                    Console.WriteLine(String.Join("", firstRow));
                }
                else
                {
                    for (int i = 0; i < minLenght; i++)
                    {
                        if (firstRow[i] == secondRow[i])
                        {
                            counter++;
                        }
                        else if (firstRow[i] < secondRow[i])
                        {
                            Console.WriteLine(String.Join("", firstRow));
                            Console.WriteLine(String.Join("", secondRow));
                        }
                        else if (firstRow[i] > secondRow[i])
                        {
                            Console.WriteLine(String.Join("", secondRow));
                            Console.WriteLine(String.Join("", firstRow));
                        }


                    }
                    if (counter == minLenght && firstRow.Length <= secondRow.Length)
                    {
                        Console.WriteLine(String.Join("", firstRow));
                        Console.WriteLine(String.Join("", secondRow));
                    }

                    else if (counter == minLenght && firstRow.Length >= secondRow.Length)
                    {
                        Console.WriteLine(String.Join("", secondRow));
                        Console.WriteLine(String.Join("", firstRow));
                    }
                    
                }


        }
       
        
    }
}


