import sqlite3

DB_FIL = "poster.db"

def skapa_tabell():
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("""
            CREATE TABLE IF NOT EXISTS poster (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                namn TEXT NOT NULL,
                info TEXT
            )
        """)
        conn.commit()
        conn.close()
    except Exception as e:
        print("Fel vid tabellskapande:", e)

def lagg_till():
    namn = input("Ange namn: ")
    info = input("Ange info: ")
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("INSERT INTO poster (namn, info) VALUES (?, ?)", (namn, info))
        conn.commit()
        conn.close()
        print("Post tillagd.")
    except Exception as e:
        print("Kunde inte lägga till post:", e)

def visa_alla():
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("SELECT * FROM poster")
        resultat = cursor.fetchall()
        conn.close()
        if resultat:
            for rad in resultat:
                print(f"{rad[0]}. {rad[1]} – {rad[2]}")
        else:
            print("Inga poster hittades.")
    except Exception as e:
        print("Fel vid hämtning:", e)

def sok():
    ord = input("Sök efter: ")
    try:
        conn = sqlite3.connect(DB_FIL)
        cursor = conn.cursor()
        cursor.execute("SELECT * FROM poster WHERE namn LIKE ? OR info LIKE ?", 
                       ('%' + ord + '%', '%' + ord + '%'))
        resultat = cursor.fetchall()
        conn.close()
        if resultat:
            for rad in resultat:
                print(f"{rad[0]}. {rad[1]} – {rad[2]}")
        else:
            print("Inga träffar.")
    except Exception as e:
        print("Fel vid sökning:", e)
