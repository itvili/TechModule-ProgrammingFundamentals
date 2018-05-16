using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05BookLibraryModification
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
                Book book = new Book()
                {
                    Title = inputBook[0],
                    Author = inputBook[1],
                    Publisher = inputBook[2],
                    RealiseDate = DateTime.ParseExact(inputBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture)
                    ,IBSN = int.Parse(inputBook[4]),
                    Price = double.Parse(inputBook[5])
                };

                booksList.Add(book);

            }

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library library = new Library() { Name = "library", Books = booksList };

            var booksAfterDate = library.Books
                .Where(x => x.RealiseDate > startDate)
                .OrderBy(x => x.RealiseDate)
                .ThenBy(x => x.Title)
                .ToList();

            foreach (var item in booksAfterDate)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Title,item.RealiseDate);
            }
        }
    }
}
