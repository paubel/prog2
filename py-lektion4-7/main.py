
import databas

def visa_meny():
    print("\nMeny:")
    print("1. Lägg till bok")
    print("2. Sök bok")
    print("3. Visa alla böcker")
    print("4. Avsluta")

def main():
    databas.skapa_databas()
    while True:
        visa_meny()
        val = input("Välj alternativ: ")
        if val == "1":
            titel = input("Titel: ")
            forfattare = input("Författare: ")
            databas.lagg_till_bok(titel, forfattare)
        elif val == "2":
            nyckelord = input("Sökord (titel/författare): ")
            databas.sok_bok(nyckelord)
        elif val == "3":
            databas.visa_alla_bocker()
        elif val == "4":
            print("Avslutar...")
            break
        else:
            print("Ogiltigt val.")

if __name__ == "__main__":
    main()
