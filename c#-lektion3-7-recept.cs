using System;
using System.Collections.Generic;
using System.Linq;

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

    public void ListIngredients()
    {
        Console.WriteLine($"\nIngredienser i {Name}:");
        foreach (var ing in Ingredients)
            Console.WriteLine($"- {ing}");
    }
}

class MealPlanner
{
    private List<Recipe> Recipes = new();

    public void AddRecipe(Recipe recipe)
    {
        Recipes.Add(recipe);
    }

    public void ListAllRecipes()
    {
        Console.WriteLine("\nTillgängliga recept:");
        foreach (var r in Recipes)
            Console.WriteLine($"- {r.Name}");
    }

    public void GenerateShoppingList()
    {
        Console.WriteLine("\nInköpslista:");
        var all = new Dictionary<(string, string), double>();

        foreach (var r in Recipes)
        {
            foreach (var ing in r.Ingredients)
            {
                var key = (ing.Name, ing.Unit);
                if (all.ContainsKey(key))
                    all[key] += ing.Amount;
                else
                    all[key] = ing.Amount;
            }
        }

        foreach (var item in all)
        {
            Console.WriteLine($"- {item.Value} {item.Key.Item2} {item.Key.Item1}");
        }
    }
}

class Program
{
    static void Main()
    {
        var pasta = new Recipe("Pasta Bolognese");
        pasta.AddIngredient("pasta", 300, "g");
        pasta.AddIngredient("köttfärs", 400, "g");
        pasta.AddIngredient("tomatsås", 2, "dl");

        var omelett = new Recipe("Omelett");
        omelett.AddIngredient("ägg", 3, "st");
        omelett.AddIngredient("mjölk", 1, "dl");
        omelett.AddIngredient("ost", 50, "g");

        var planner = new MealPlanner();
        planner.AddRecipe(pasta);
        planner.AddRecipe(omelett);

        planner.ListAllRecipes();
        pasta.ListIngredients();
        omelett.ListIngredients();
        planner.GenerateShoppingList();
    }
}
