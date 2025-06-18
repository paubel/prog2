using RPG.Spelare;
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var p = new Player { Namn = "Ella" };
        Console.WriteLine($"Spelaren heter: {p.Namn}");
    }
}
