using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; }
    public string Author { get; }
    public bool Available { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        Available = true;
    }

    public bool Borrow()
    {
        if (Available)
        {
            Available = false;
            return true;
        }
        return false;
    }

    public void Return()
    {
        Available = true;
    }

    public override string ToString()
    {
        string status = Available ? "Tillgänglig" : "Utlånad";
        return $"{Title} av {Author} – {status}";
    }
}

class Member
{
    public string Name { get; }
    private List<Book> borrowedBooks;

    public Member(string name)
    {
        Name = name;
        borrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        if (book.Borrow())
        {
            borrowedBooks.Add(book);
            Console.WriteLine($"{Name} lånade {book.Title}.");
        }
        else
        {
            Console.WriteLine($"{book.Title} är redan utlånad.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (borrowedBooks.Contains(book))
        {
            book.Return();
            borrowedBooks.Remove(book);
            Console.WriteLine($"{Name} lämnade tillbaka {book.Title}.");
        }
        else
        {
            Console.WriteLine($"{Name} har inte {book.Title}.");
        }
    }

    public void ListBooks()
    {
        Console.WriteLine($"{Name} har lånat:");
        foreach (var book in borrowedBooks)
            Console.WriteLine($"- {book}");
        if (borrowedBooks.Count == 0)
            Console.WriteLine("Inga böcker.");
    }
}

class Library
{
    private List<Book> books = new();
    private List<Member> members = new();

    public void AddBook(string title, string author)
    {
        books.Add(new Book(title, author));
    }

    public void RegisterMember(string name)
    {
        members.Add(new Member(name));
    }

    public Book FindBook(string title) =>
        books.FirstOrDefault(b => b.Title == title);

    public Member FindMember(string name) =>
        members.FirstOrDefault(m => m.Name == name);

    public void ListBooks()
    {
        Console.WriteLine("Bibliotekets böcker:");
        foreach (var book in books)
            Console.WriteLine($"- {book}");
    }
}

class Program
{
    static void Main()
    {
        var lib = new Library();
        lib.AddBook("1984", "George Orwell");
        lib.AddBook("Sagan om ringen", "J.R.R. Tolkien");
        lib.RegisterMember("Ali");

        var book = lib.FindBook("1984");
        var member = lib.FindMember("Ali");

        member?.BorrowBook(book);
        member?.ListBooks();
        member?.ReturnBook(book);
        member?.ListBooks();
        lib.ListBooks();
    }
}
