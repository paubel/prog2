using System;
using Microsoft.Data.Sqlite;

public static class Databas
{
    const string CONNECTION_STRING = "Data Source=poster.db";

    public static void SkapaDatabas()
    {
        using var conn = new SqliteConnection(CONNECTION_STRING);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = @"CREATE TABLE IF NOT EXISTS poster (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                namn TEXT NOT NULL
                            );";
        cmd.ExecuteNonQuery();
    }

    public static void LaggTill()
    {
        Console.Write("Ange namn att lägga till: ");
        string namn = Console.ReadLine();

        using var conn = new SqliteConnection(CONNECTION_STRING);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO poster (namn) VALUES (@namn)";
        cmd.Parameters.AddWithValue("@namn", namn);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Posten har lagts till.");
    }

    public static void VisaAlla()
    {
        using var conn = new SqliteConnection(CONNECTION_STRING);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, namn FROM poster";
        using var reader = cmd.ExecuteReader();
        Console.WriteLine("\nAlla poster:");
        while (reader.Read())
        {
            Console.WriteLine($"[{reader.GetInt32(0)}] {reader.GetString(1)}");
        }
    }

    public static void Sok()
    {
        Console.Write("Skriv något att söka efter: ");
        string term = Console.ReadLine();

        using var conn = new SqliteConnection(CONNECTION_STRING);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, namn FROM poster WHERE namn LIKE @term";
        cmd.Parameters.AddWithValue("@term", $"%{term}%");
        using var reader = cmd.ExecuteReader();
        Console.WriteLine("\nSökresultat:");
        while (reader.Read())
        {
            Console.WriteLine($"[{reader.GetInt32(0)}] {reader.GetString(1)}");
        }
    }
}
