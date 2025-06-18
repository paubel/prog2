using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();
        string url = "https://official-joke-api.appspot.com/random_joke";

        try
        {
            string json = await client.GetStringAsync(url);
            Joke joke = JsonSerializer.Deserialize<Joke>(json);
            Console.WriteLine("\nSkämt:");
            Console.WriteLine(joke.setup);
            Console.WriteLine(joke.punchline);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Kunde inte hämta skämt: " + ex.Message);
        }
    }

    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
