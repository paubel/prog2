using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SkamtRegister
{
    public partial class Form1 : Form
    {
        private string setup, punchline;

        public Form1()
        {
            InitializeComponent();
            SkapaDatabas();
        }

        private void SkapaDatabas()
        {
            using var conn = new SqliteConnection("Data Source=skamt.db");
            conn.Open();
            var kommando = conn.CreateCommand();
            kommando.CommandText =
                @"CREATE TABLE IF NOT EXISTS skamt (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    setup TEXT,
                    punchline TEXT
                );";
            kommando.ExecuteNonQuery();
        }

        private async void btnHamta_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            try
            {
                var response = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
                var data = JsonSerializer.Deserialize<Skamt>(response);
                setup = data.setup;
                punchline = data.punchline;
                lblSkamt.Text = $"{setup} - {punchline}";
            }
            catch (Exception ex)
            {
                lblSkamt.Text = "Kunde inte hämta skämt: " + ex.Message;
                MessageBox.Show("Fel vid hämtning: " + ex.Message);
            }
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(setup)) return;

            using var conn = new SqliteConnection("Data Source=skamt.db");
            conn.Open();
            var kommando = conn.CreateCommand();
            kommando.CommandText = @"INSERT INTO skamt (setup, punchline) VALUES ($setup, $punchline)";
            kommando.Parameters.AddWithValue("$setup", setup);
            kommando.Parameters.AddWithValue("$punchline", punchline);
            kommando.ExecuteNonQuery();

            lblSkamt.Text = "Skämtet sparades!";
            MessageBox.Show("Skämt sparat till databasen!");
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            using var conn = new SqliteConnection("Data Source=skamt.db");
            conn.Open();
            var kommando = conn.CreateCommand();
            kommando.CommandText = @"SELECT * FROM skamt";
            using var reader = kommando.ExecuteReader();
            lstResultat.Items.Clear();

            int antal = 0;
            while (reader.Read())
            {
                string text = $"{reader.GetString(1)} - {reader.GetString(2)}";
                lstResultat.Items.Add(text);
                antal++;
            }

            MessageBox.Show($"Antal skämt hämtade från databasen: {antal}");
        }

        private void lstResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

    public class Skamt
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
