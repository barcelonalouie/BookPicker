using System;
using System.Collections.Generic;

class Program
{
    class BookList
    {
        public List<Book> books;

        public BookList()
        {
            books = new List<Book>
            {
                new Book("The Relentless Moon", "Mary Kowal", "Sci-Fi"),
                new Book("A Game of Thrones: A Song of Ice and Fire", "George Martin", "Fantasy"),
                new Book("Clean Cut", "Theresa Monsour", "Mystery"),
                new Book("Everyday", "David Levithan", "Romance"),
                new Book("Vortex", "Robert Wilson", "Sci-Fi"),
                new Book("Royal Assassin", "Robin Hobb", "Fantasy"),
                new Book("The Drop", "Michael Connely", "Mystery"),
                new Book("Another Day", "David Levithan", "Romance")
            };
        }

        public List<string> GetGenres()
        {
            List<string> genres = new List<string>();
            foreach (Book book in books)
            {
                if (!genres.Contains(book.Genre))
                {
                    genres.Add(book.Genre);
                }
            }
            return genres;
        }

        public List<Book> GetBooksByGenre(string genre)
        {
            List<Book> genreBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Genre == genre)
                {
                    genreBooks.Add(book);
                }
            }
            return genreBooks;
        }
    }

    static void Main(string[] args)
    {
        BookList booklist = new BookList();

        Console.WriteLine("Here are the available genres: ");
        List<string> genres = booklist.GetGenres();
        foreach (string genre in genres)
        {
            Console.WriteLine(genre);
        }

        Console.Write("Enter chosen genre here: ");
        string selectedGenre = Console.ReadLine();

        List<Book> booksByGenre = booklist.GetBooksByGenre(selectedGenre);
        if (booksByGenre.Count > 0)
        {
            Console.WriteLine($"Here are the available books in the {selectedGenre} genre:");
            foreach (Book book in booksByGenre)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }
        else
        {
            Console.WriteLine("Run it again.");
        }
    }
}
