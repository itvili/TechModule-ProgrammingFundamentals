using System;

namespace _02AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfPhrases = int.Parse(Console.ReadLine());

            string[] phrases = new string[] {"Excellent product.", "Such a great product."
                , "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};

            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                 "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            for (int i = 0; i < numbersOfPhrases; i++)
            {
               
                var phrase = phrases[rnd.Next(0, phrases.Length - 1)];
                var event1 = events[rnd.Next(0, events.Length - 1)];
                string autor = authors[rnd.Next(0, authors.Length - 1)];
                string city = cities[rnd.Next(0, cities.Length - 1)];

                Console.WriteLine("{0} {1} {2} - {3}", phrase,event1,autor,city);

            }

        }
    }
       
    
}
