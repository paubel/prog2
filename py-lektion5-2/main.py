import databas

def visa_meny():
    print("1. Lägg till post")
    print("2. Visa alla")
    print("3. Sök")
    print("4. Avsluta")

def main():
    databas.skapa_tabell()
    while True:
        visa_meny()
        val = input("Val: ")
        if val == "1":
            databas.lagg_till()
        elif val == "2":
            databas.visa_alla()
        elif val == "3":
            databas.sok()
        elif val == "4":
            break

if __name__ == "__main__":
    main()
