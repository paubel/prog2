def konverteringsfel():
    try:
        tal = int(input("Skriv ett heltal: "))
        print(f"Du skrev: {tal}")
    except ValueError:
        print("Fel: Du måste skriva ett heltal!")

def filfel():
    filnamn = input("Ange filnamn att läsa: ")
    try:
        with open(filnamn, "r", encoding="utf-8") as f:
            innehall = f.read()
            print("Innehåll i filen:\n", innehall)
    except FileNotFoundError:
        print("Fel: Filen hittades inte.")
    except Exception as e:
        print(f"Något gick fel: {e}")

def divisionsfel():
    try:
        tal1 = float(input("Skriv täljaren: "))
        tal2 = float(input("Skriv nämnaren: "))
        resultat = tal1 / tal2
        print(f"Resultatet är: {resultat}")
    except ZeroDivisionError:
        print("Fel: Du kan inte dividera med noll!")
    except ValueError:
        print("Fel: Du måste ange siffror!")

def main():
    while True:
        print("\n--- Felhanteringsexempel ---")
        print("1. Konverteringsfel (int)")
        print("2. Läs fil")
        print("3. Division")
        print("4. Avsluta")
        val = input("Välj alternativ: ")

        if val == "1":
            konverteringsfel()
        elif val == "2":
            filfel()
        elif val == "3":
            divisionsfel()
        elif val == "4":
            print("Avslutar programmet.")
            break
        else:
            print("Ogiltigt val.")

main()
