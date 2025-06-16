using System;

class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Title} av {Author}");
    }
}

class Program
{
    static void Main()
    {
        // Skapa ett objekt av klassen Book
        Book book1 = new Book("1984", "George Orwell");

        // Anropa metoden som skriver ut information
        book1.PrintInfo();

        // Du kan skapa fler böcker om du vill
        Book book2 = new Book("Brave New World", "Aldous Huxley");
        book2.PrintInfo();
    }
}
