using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<(string name, int score)> scores = new List<(string, int)>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Spel – Topplista ===");
            Console.WriteLine("1. Lägg till resultat");
            Console.WriteLine("2. Visa topplista");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange namn: ");
                    string name = Console.ReadLine();

                    Console.Write("Ange poäng: ");
                    if (int.TryParse(Console.ReadLine(), out int score))
                    {
                        scores.Add((name, score));
                        Console.WriteLine("Resultat tillagt!");
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning, poängen måste vara ett heltal.");
                    }
                    Pause();
                    break;

                case "2":
                    if (scores.Count == 0)
                    {
                        Console.WriteLine("Ingen data tillgänglig ännu.");
                    }
                    else
                    {
                        scores.Sort((a, b) => b.score.CompareTo(a.score)); // sortera fallande
                        Console.WriteLine("\n--- Topplista ---");
                        int rank = 1;
                        foreach (var entry in scores)
                        {
                            Console.WriteLine($"{rank}. {entry.name} – {entry.score} poäng");
                            rank++;
                        }
                    }
                    Pause();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    Pause();
                    break;
            }
        }

        Console.WriteLine("Programmet är avslutat. Tack för att du spelade!");
    }

    static void Pause()
    {
        Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
        Console.ReadKey();
    }
}
