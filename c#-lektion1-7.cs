using System;

class Program
{
    static void ShowMenu()
    {
        Console.WriteLine("1. Enter name and age");
        Console.WriteLine("2. Calculate when you turn 100");
        Console.WriteLine("3. Exit");
    }

    static (string, int) GetUserInfo()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age;

        while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 120)
        {
            Console.Write("Invalid age. Please enter a valid age between 0 and 120: ");
        }

        return (name, age);
    }

    static int CalculateYearWhen100(int age)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear + (100 - age);
    }

    static void Main()
    {
        string name = "";
        int age = 0;
        bool running = true;

        while (running)
        {
            ShowMenu();
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();
            Console.WriteLine(); // tom rad för läsbarhet

            switch (option)
            {
                case "1":
                    (name, age) = GetUserInfo();
                    Console.WriteLine($"Hello {name}, age {age}.\n");
                    break;
                case "2":
                    if (name != "")
                    {
                        int year = CalculateYearWhen100(age);
                        Console.WriteLine($"{name}, you will turn 100 in the year {year}.\n");
                    }
                    else
                    {
                        Console.WriteLine("You must enter your name and age first.\n");
                    }
                    break;
                case "3":
                    Console.WriteLine("Exiting program. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }
    }
}
