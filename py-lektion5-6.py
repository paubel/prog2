import tkinter as tk
import requests
import sqlite3

# Skapa databas
conn = sqlite3.connect("skamt.db")
cursor = conn.cursor()
cursor.execute("""
    CREATE TABLE IF NOT EXISTS skamt (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        setup TEXT,
        punchline TEXT
    )
""")
conn.commit()

senaste_skamt = None

# Funktioner
def hamta_skamt():
    global senaste_skamt
    response = requests.get("https://official-joke-api.appspot.com/random_joke")
    if response.status_code == 200:
        data = response.json()
        skamt_label.config(text=f"{data['setup']} - {data['punchline']}")
        senaste_skamt = (data['setup'], data['punchline'])

def spara_skamt():
    if senaste_skamt:
        cursor.execute("INSERT INTO skamt (setup, punchline) VALUES (?, ?)", senaste_skamt)
        conn.commit()
        skamt_label.config(text="Skämtet sparat!")

def visa_skamt():
    cursor.execute("SELECT * FROM skamt")
    rader = cursor.fetchall()
    output = "\n".join([f"{r[1]} - {r[2]}" for r in rader])
    skamt_label.config(text=output[:300] + "..." if len(output) > 300 else output)

# GUI
root = tk.Tk()
root.title("Skämtregister")

tk.Button(root, text="Hämta skämt", command=hamta_skamt).pack()
tk.Button(root, text="Spara skämt", command=spara_skamt).pack()
tk.Button(root, text="Visa alla skämt", command=visa_skamt).pack()
skamt_label = tk.Label(root, text="", wraplength=300, justify="left")
skamt_label.pack()

root.mainloop()
