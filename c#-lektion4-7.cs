using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        SkapaDatabas();
        while (true)
        {
            Console.WriteLine("\n1. Lägg till bok\n2. Sök bok\n3. Visa alla böcker\n4. Avsluta");
            var val = Console.ReadLine();
            if (val == "1") LaggTillBok();
            else if (val == "2") SokBok();
            else if (val == "3") VisaAllaBocker();
            else if (val == "4") break;
            else Console.WriteLine("Ogiltigt val.");
        }
    }

    static void SkapaDatabas()
    {
        try
        {
            using var conn = new SqliteConnection("Data Source=bibliotek.db");
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS bocker (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    titel TEXT NOT NULL,
                    forfattare TEXT NOT NULL
                );";
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine("Fel vid skapande av databas: " + e.Message);
        }
    }

    static void LaggTillBok()
    {
        Console.Write("Titel: ");
        string titel = Console.ReadLine();
        Console.Write("Författare: ");
        string forfattare = Console.ReadLine();

        using var conn = new SqliteConnection("Data Source=bibliotek.db");
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO bocker (titel, forfattare) VALUES ($titel, $forfattare);";
        cmd.Parameters.AddWithValue("$titel", titel);
        cmd.Parameters.AddWithValue("$forfattare", forfattare);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Boken har lagts till.");
    }

    static void SokBok()
    {
        Console.Write("Skriv titel eller författare att söka efter: ");
        string sok = Console.ReadLine();

        using var conn = new SqliteConnection("Data Source=bibliotek.db");
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT titel, forfattare FROM bocker
            WHERE titel LIKE $sok OR forfattare LIKE $sok;";
        cmd.Parameters.AddWithValue("$sok", "%" + sok + "%");

        using var reader = cmd.ExecuteReader();
        Console.WriteLine("Sökresultat:");
        while (reader.Read())
        {
            Console.WriteLine($"- {reader.GetString(0)} av {reader.GetString(1)}");
        }
    }

    static void VisaAllaBocker()
    {
        using var conn = new SqliteConnection("Data Source=bibliotek.db");
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT titel, forfattare FROM bocker;";

        using var reader = cmd.ExecuteReader();
        Console.WriteLine("Alla böcker i biblioteket:");
        while (reader.Read())
        {
            Console.WriteLine($"- {reader.GetString(0)} av {reader.GetString(1)}");
        }
    }
}
