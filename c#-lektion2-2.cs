using System;
using System.Collections.Generic;

class Program
{
    // Metod för att räkna ut medelvärde
    static double Average(List<int> values)
    {
        int sum = 0;
        foreach (int v in values)
            sum += v;
        return (double)sum / values.Count;
    }

    static void Main()
    {
        Console.WriteLine("=== Vad är en array? ===");
        Console.WriteLine("En array är en fast storlek av element av samma datatyp.");
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        Console.WriteLine("Array med int:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nEller direkt med värden:");
        string[] fruits = { "apple", "banana", "cherry" };

        Console.WriteLine("foreach (string fruit in fruits):");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nfor-loop med index:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
        }

        Console.WriteLine("\n=== Vad är en List<T>? ===");
        Console.WriteLine("List<T> är en flexibel lista som kan växa eller krympa.");

        List<int> scores = new List<int>();
        scores.Add(10);
        scores.Add(20);
        scores.Add(30);

        Console.WriteLine("\nÅtkomst och metoder för List<T>:");
        Console.WriteLine($"Första värdet: {scores[0]}"); // 10
        scores[1] = 25; // Ändrar andra värdet till 25
        scores.Remove(25); // Tar bort värdet 25
        Console.WriteLine($"Antal element: {scores.Count}");

        Console.WriteLine("\nIteration med foreach:");
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine("\n=== När använda vad? ===");
        Console.WriteLine("Array – När antalet element är fast och du inte behöver lägga till/ta bort.");
        Console.WriteLine("List<T> – När du behöver mer flexibilitet och dynamik.");

        Console.WriteLine("\n=== Kombinera List<T> med metoder ===");
        List<int> testScores = new List<int> { 75, 80, 90 };
        double avg = Average(testScores);
        Console.WriteLine($"Average: {avg}");
    }
}
