using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05HandsOfCards
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
           
            
            Dictionary<string, long> namesAndValue = new Dictionary<string, long>();
            Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();
            
            while (input!="JOKER")
            {
                int separatingDots = input.IndexOf(':');
                string name = input.Substring(0,separatingDots);
                var playerHand = input.Substring(separatingDots + 1).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!playerCards.ContainsKey(name))
                {
                    playerCards[name] = new List<string>();
                }

                playerCards[name].AddRange(playerHand);
                input = Console.ReadLine();
            }

            foreach (var person in playerCards)
            {
                string name = person.Key;
                List<string> cards = person.Value.Distinct().ToList();
                long result = 0;
                for (int i = 0; i < cards.Count; i++)
                {
                    string currentCard = cards[i];
                    string type = currentCard.Substring(currentCard.Length - 1);
                    string power = currentCard.Substring(0, currentCard.Length - 1);

                    result += CreatePower(power) * CreateTypes(type);
                }

                namesAndValue[name] = result;
            }

            foreach (var item in namesAndValue)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            
        }
        static int CreatePower(string power)
        {
            Dictionary<string, int> cardsPower = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                cardsPower[i.ToString()] = i;
            }

            cardsPower.Add("J", 11);
            cardsPower.Add("Q", 12);
            cardsPower.Add("K", 13);
            cardsPower.Add("A", 14);

            return cardsPower[power];
        }

        static int CreateTypes(string cardTypes)
        {
            Dictionary<string, int> cardsType = new Dictionary<string, int>();

            cardsType.Add("S", 4);
            cardsType.Add("H", 3);
            cardsType.Add("D", 2);
            cardsType.Add("C", 1);

            return cardsType[cardTypes];
        }
    }
}
