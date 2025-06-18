
import sqlite3
DB_FIL = "bibliotek.db"
def skapa_databas():
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("""
            CREATE TABLE IF NOT EXISTS bocker (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                titel TEXT NOT NULL,
                forfattare TEXT NOT NULL
            )
        """)
        conn.commit()
        conn.close()
    except Exception as e:
        print("Fel vid skapande av databas:", e)

def lagg_till_bok(titel, forfattare):
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("INSERT INTO bocker (titel, forfattare) VALUES (?, ?)", (titel, forfattare))
        conn.commit()
        conn.close()
        print("Bok tillagd!")
    except Exception as e:
        print("Kunde inte lägga till bok:", e)

def sok_bok(nyckelord):
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("SELECT * FROM bocker WHERE titel LIKE ? OR forfattare LIKE ?", 
                       ('%' + nyckelord + '%', '%' + nyckelord + '%'))
        resultat = cursor.fetchall()
        conn.close()
        for bok in resultat:
            print(f"{bok[0]}. {bok[1]} – {bok[2]}")
        if not resultat:
            print("Inga träffar.")
    except Exception as e:
        print("Sökning misslyckades:", e)

def visa_alla_bocker():
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("SELECT * FROM bocker")
        resultat = cursor.fetchall()
        conn.close()
        for bok in resultat:
            print(f"{bok[0]}. {bok[1]} – {bok[2]}")
        if not resultat:
            print("Inga böcker finns än.")
    except Exception as e:
        print("Kunde inte hämta böcker:", e)
