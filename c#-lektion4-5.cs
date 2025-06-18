using System;
using System.IO;

class Program
{
    const string FILNAMN = "anteckningar.txt";

    static void Main()
    {
        while (true)
        {
            VisaMeny();
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    SkrivAnteckning();
                    break;
                case "2":
                    VisaAnteckningar();
                    break;
                case "3":
                    Console.WriteLine("Programmet avslutas.");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    static void VisaMeny()
    {
        Console.WriteLine("\nMENY");
        Console.WriteLine("1. Skriv ny anteckning");
        Console.WriteLine("2. Visa anteckningar");
        Console.WriteLine("3. Avsluta");
        Console.Write("Välj ett alternativ: ");
    }

    static void SkrivAnteckning()
    {
        Console.Write("Skriv din anteckning: ");
        string text = Console.ReadLine();
        try
        {
            File.AppendAllText(FILNAMN, $"{DateTime.Now}: {text}\n");
            Console.WriteLine("Anteckningen har sparats.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ett fel uppstod: {ex.Message}");
        }
    }

    static void VisaAnteckningar()
    {
        try
        {
            if (File.Exists(FILNAMN))
            {
                string[] rader = File.ReadAllLines(FILNAMN);
                Console.WriteLine("\nTidigare anteckningar:");
                foreach (var rad in rader)
                {
                    Console.WriteLine($"- {rad}");
                }
            }
            else
            {
                Console.WriteLine("Det finns ännu inga anteckningar.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kunde inte läsa filen: {ex.Message}");
        }
    }
}
