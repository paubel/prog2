using System;

class Program
{
    static void Main()
    {
        Databas.SkapaDatabas();

        while (true)
        {
            Console.WriteLine("\nMeny:");
            Console.WriteLine("1. Lägg till post");
            Console.WriteLine("2. Visa alla");
            Console.WriteLine("3. Sök post");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj: ");
            var val = Console.ReadLine();
            switch (val)
            {
                case "1": Databas.LaggTill(); break;
                case "2": Databas.VisaAlla(); break;
                case "3": Databas.Sok(); break;
                case "4": return;
                default: Console.WriteLine("Ogiltigt val."); break;
            }
        }
    }
}
