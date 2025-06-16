using System;

class Program
{
    static void Main()
    {
        Run();
    }

    static void PrintMenu()
    {
        Console.WriteLine("1. Say hello");
        Console.WriteLine("2. Exit");
    }

    static void Run()
    {
        while (true)
        {
            PrintMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Hello!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine(); // tom rad för bättre läsbarhet
        }
    }
}
