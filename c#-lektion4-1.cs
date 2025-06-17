using System;
using System.IO;
using System.Collections.Generic;

class Ingredient
{
    public string Name { get; }
    public double Amount { get; }
    public string Unit { get; }

    public Ingredient(string name, double amount, string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }

    public override string ToString() => $"{Amount} {Unit} {Name}";
}

class Recipe
{
    public string Name { get; }
    public List<Ingredient> Ingredients { get; }

    public Recipe(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
    }

    public void AddIngredient(string name, double amount, string unit)
    {
        Ingredients.Add(new Ingredient(name, amount, unit));
    }

    // 💾 Spara receptet till fil i projektmappen
    public void SaveToFile()
    {
        string path = Path.Combine(ProjectFolder(), "recept.txt");
        using (StreamWriter sw = new StreamWriter(path, append: true))
        {
            sw.WriteLine($"Recept: {Name}");
            foreach (var ing in Ingredients)
            {
                sw.WriteLine($"- {ing}");
            }
            sw.WriteLine();
        }
    }

    private static string ProjectFolder()
    {
        // Gå från bin/Debug/netX.X till projektmappen
        return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
    }
}

class Program
{
    static void Main()
    {
        string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

        // === Grundläggande filhantering ===
        string exempelPath = Path.Combine(projectPath, "exempel.txt");

        File.WriteAllText(exempelPath, "Hej filvärlden!\nNy rad text.");
        File.AppendAllText(exempelPath, "\nEn extra rad text.");

        Console.WriteLine("=== Hela innehållet i filen ===");
        string innehåll = File.ReadAllText(exempelPath);
        Console.WriteLine(innehåll);

        Console.WriteLine("\n=== Rad för rad ===");
        string[] rader = File.ReadAllLines(exempelPath);
        foreach (var rad in rader)
        {
            Console.WriteLine(rad);
        }

        // === Spara ett recept till recept.txt i projektmappen ===
        var recept = new Recipe("Pannkakor");
        recept.AddIngredient("ägg", 2, "st");
        recept.AddIngredient("mjöl", 2.5, "dl");
        recept.AddIngredient("mjölk", 6, "dl");

        recept.SaveToFile();

        Console.WriteLine($"\nFilerna har sparats i:\n{projectPath}");
    }
}
