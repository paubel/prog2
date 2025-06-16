using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program
{
    static void AddBook(List<Book> books)
    {
        Console.Write("Titel: ");
        string title = Console.ReadLine();

        Console.Write("Författare: ");
        string author = Console.ReadLine();

        Console.Write("År: ");
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Ogiltigt år. Sätts till 0.");
            year = 0;
        }

        books.Add(new Book(title, author, year));
        Console.WriteLine("Boken har lagts till.");
    }

    static void SearchBook(List<Book> books)
    {
        Console.Write("Sök efter titel eller författare: ");
        string search = Console.ReadLine().ToLower();

        var result = books.Where(b =>
            b.Title.ToLower().Contains(search) || b.Author.ToLower().Contains(search));

        if (!result.Any())
        {
            Console.WriteLine("Inga böcker hittades.");
        }
        else
        {
            Console.WriteLine("\nSökresultat:");
            foreach (var book in result)
            {
                Console.WriteLine($"{book.Title} av {book.Author} ({book.Year})");
            }
        }
    }

    static void PrintBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Inga böcker i listan.");
            return;
        }

        var sorted = books.OrderBy(b => b.Title).ToList();

        Console.WriteLine("\nBoklista:");
        foreach (var book in sorted)
        {
            Console.WriteLine($"{book.Title} av {book.Author} ({book.Year})");
        }
    }

    static void Main()
    {
        List<Book> bookList = new List<Book>();

        while (true)
        {
            Console.WriteLine("\n1. Lägg till bok");
            Console.WriteLine("2. Sök bok");
            Console.WriteLine("3. Visa alla böcker");
            Console.WriteLine("4. Avsluta");
            Console.Write("Ditt val: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook(bookList);
                    break;
                case "2":
                    SearchBook(bookList);
                    break;
                case "3":
                    PrintBooks(bookList);
                    break;
                case "4":
                    Console.WriteLine("Programmet avslutas.");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
}
