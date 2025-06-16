using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Vad är en Dictionary i C#? ===");
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Anna"] = 25;
        ages["Bo"] = 30;

        Console.WriteLine("\nÅtkomst:");
        Console.WriteLine($"Bo är {ages["Bo"]} år gammal.");

        Console.WriteLine("\nLägga till:");
        ages.Add("Cleo", 22);
        Console.WriteLine("Cleo tillagd.");

        Console.WriteLine("\nÄndra:");
        ages["Anna"] = 26;
        Console.WriteLine("Annas ålder ändrad till 26.");

        Console.WriteLine("\nTa bort:");
        ages.Remove("Bo");
        Console.WriteLine("Bo borttagen.");

        Console.WriteLine("\nKolla om en nyckel finns:");
        if (ages.ContainsKey("Cleo"))
            Console.WriteLine("Cleo finns i listan.");

        Console.WriteLine("\nLoop genom dictionary:");
        foreach (KeyValuePair<string, int> pair in ages)
        {
            Console.WriteLine($"{pair.Key} är {pair.Value} år gammal.");
        }

        Console.WriteLine("\n=== Varför använda Dictionary? ===");
        Console.WriteLine("En dictionary ger snabb åtkomst till värden genom unika nycklar.");
        Console.WriteLine("Till skillnad från listor där du söker via index, använder du nyckeln direkt.");
    }
}
