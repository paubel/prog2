RECEPTFIL = "recept.txt"

def lägga_till_recept():
    namn = input("Vad heter receptet? ").strip()
    ingredienser = input("Ange ingredienser (komma-separerade): ").strip()
    
    if not namn or not ingredienser:
        print("Du måste ange både namn och ingredienser.")
        return

    rad = f"{namn}|{ingredienser}\n"
    try:
        with open(RECEPTFIL, "a", encoding="utf-8") as fil:
            fil.write(rad)
        print(f"Receptet '{namn}' sparades.")
    except Exception as e:
        print(f"Något gick fel: {e}")

def visa_recept():
    try:
        with open(RECEPTFIL, "r", encoding="utf-8") as fil:
            rader = fil.readlines()

        if not rader:
            print("Inga recept hittades.")
            return

        print("\nSparade recept:")
        for rad in rader:
            try:
                namn, ingredienser = rad.strip().split("|")
                print(f"\nRecept: {namn}")
                print("Ingredienser:")
                for ing in ingredienser.split(","):
                    print(f"- {ing.strip()}")
            except ValueError:
                print("Fel i filformatet – kunde inte tolka en rad.")
    except FileNotFoundError:
        print("Filen med recept finns inte ännu.")
    except Exception as e:
        print(f"Fel vid läsning: {e}")

def visa_meny():
    print("\nMeny:")
    print("1. Lägg till recept")
    print("2. Visa recept")
    print("3. Avsluta")

def main():
    while True:
        visa_meny()
        val = input("Välj ett alternativ (1-3): ").strip()
        if val == "1":
            lägga_till_recept()
        elif val == "2":
            visa_recept()
        elif val == "3":
            print("Programmet avslutas. Tack!")
            break
        else:
            print("Ogiltigt val, försök igen.")

if __name__ == "__main__":
    main()
