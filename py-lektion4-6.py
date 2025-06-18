import sqlite3

DB_NAMN = "recept.db"

def skapa_databas_och_tabell():
    conn = sqlite3.connect(DB_NAMN)
    cursor = conn.cursor()
    cursor.execute("""
    CREATE TABLE IF NOT EXISTS recept (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        namn TEXT NOT NULL,
        ingredienser TEXT
    )
    """)
    conn.commit()
    conn.close()

def lägg_till_recept(namn, ingredienser):
    conn = sqlite3.connect(DB_NAMN)
    cursor = conn.cursor()
    cursor.execute("INSERT INTO recept (namn, ingredienser) VALUES (?, ?)", (namn, ingredienser))
    conn.commit()
    conn.close()
    print(f"Receptet '{namn}' har lagts till.")

def visa_alla_recept():
    conn = sqlite3.connect(DB_NAMN)
    cursor = conn.cursor()
    cursor.execute("SELECT * FROM recept")
    rader = cursor.fetchall()
    if not rader:
        print("Inga recept hittades.")
    else:
        for rad in rader:
            print(f"\nRecept: {rad[1]}")
            print(f"Ingredienser: {rad[2]}")
    conn.close()

def main():
    skapa_databas_och_tabell()
    while True:
        print("\nMeny:")
        print("1. Lägg till recept")
        print("2. Visa alla recept")
        print("3. Avsluta")
        val = input("Välj: ")
        if val == "1":
            namn = input("Receptets namn: ")
            ingredienser = input("Ange ingredienser (kommaseparerade): ")
            lägg_till_recept(namn, ingredienser)
        elif val == "2":
            visa_alla_recept()
        elif val == "3":
            print("Avslutar programmet.")
            break
        else:
            print("Ogiltigt val. Försök igen.")

if __name__ == "__main__":
    main()
