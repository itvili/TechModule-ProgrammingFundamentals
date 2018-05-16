using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05BookLibrary
{
    class Program
    {
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime RealiseDate { get; set; }
            public int IBSN { get; set; }
            public double Price { get; set; }


        }
        static void Main(string[] args)
        {
            int numberOfbooks = int.Parse(Console.ReadLine());

            List<Book> booksList = new List<Book>();
            for (int i = 0; i < numberOfbooks; i++)
            {
                string[] inputBook = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book() { Title = inputBook[0], Author = inputBook[1], Publisher = inputBook[2],
                    RealiseDate = DateTime.ParseExact(inputBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture)
                    , IBSN = int.Parse(inputBook[4]), Price = double.Parse(inputBook[5]) };

                booksList.Add(book);

            }
            Library library = new Library() { Name = "library", Books = booksList};

            var output = library.Books
                .GroupBy(x => x.Author)
                .Select(g => new { Author = g.Key, Prices = g.Sum(s => s.Price) })
                .OrderByDescending(x => x.Prices)
                .ThenBy(x => x.Author).ToList();

            foreach (var item in output)
            {

                Console.WriteLine("{0} -> {1:f2}",item.Author,item.Prices);
            }
        }
    }
}
