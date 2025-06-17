using System;
using System.IO;

class Program
{
    static void Main()
    {
        // === Exempel 1: Konverteringsfel ===
        try
        {
            Console.Write("Skriv ett heltal: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Du skrev: {tal}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Fel: Du måste skriva ett heltal!");
        }

        Console.WriteLine("\n---");

        // === Exempel 2: Fil saknas ===
        try
        {
            string text = File.ReadAllText("saknas.txt");
            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Filen hittades inte.");
        }

        Console.WriteLine("\n---");

        // === Exempel 3: Flera typer av fel ===
        try
        {
            Console.Write("Skriv en nämnare för 10 / x: ");
            int nämnare = int.Parse(Console.ReadLine());
            int resultat = 10 / nämnare;
            Console.WriteLine($"Resultat: {resultat}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Du kan inte dividera med noll!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Fel inmatning – skriv ett tal.");
        }
    }
}
