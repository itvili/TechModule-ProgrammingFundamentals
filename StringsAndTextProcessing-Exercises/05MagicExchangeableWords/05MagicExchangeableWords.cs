using System;
using System.Collections.Generic;

namespace _05MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstText = input[0];
            string secondText = input[1];

            int minLength = Math.Min(firstText.Length, secondText.Length);
            int maxLength = Math.Max(firstText.Length, secondText.Length);


            Dictionary<char, char> matches = new Dictionary<char, char>();
            bool isExchangable = true;

            for (int i = 0; i < minLength; i++)
            {

                var firstSymbol = firstText[i];
                var secondSymbol = secondText[i];

                if (matches.ContainsKey(firstSymbol) && matches.ContainsValue(secondSymbol) && matches[firstSymbol] == secondSymbol)
                {
                    continue;
                }

                if (!matches.ContainsKey(firstSymbol) && !matches.ContainsValue(secondSymbol))
                {
                    matches[firstSymbol] = secondSymbol;
                }
                if (matches.ContainsKey(firstSymbol) && !matches.ContainsValue(secondSymbol))
                {
                    isExchangable = false;
                    break;

                }
                if (!matches.ContainsKey(firstSymbol) && matches.ContainsValue(secondSymbol))
                {
                    isExchangable = false;
                    break;
                }
                               
            }

            if (minLength!=maxLength)
            {
                string longerText = firstText.Length > secondText.Length ? longerText = firstText : longerText = secondText;

                for (int i = minLength; i < maxLength; i++)
                {
                    char symbolTocheck = longerText[i];

                    if (!matches.ContainsValue(symbolTocheck))
                    {
                        if (matches.ContainsKey(symbolTocheck))
                        {
                            isExchangable = true;
                        }
                        else
                        {
                            isExchangable = false;
                        }
                                             
                    }
                    
                }
            }

            if (isExchangable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
