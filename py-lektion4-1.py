def spara_recept(namn, ingredienser):
    with open("recept.txt", "a", encoding="utf-8") as fil:
        fil.write(f"Recept: {namn}\n")
        for ing in ingredienser:
            fil.write(f"- {ing}\n")
        fil.write("\n")  # tom rad mellan recept

def las_recept():
    try:
        with open("recept.txt", "r", encoding="utf-8") as fil:
            innehall = fil.read()
            print("=== Sparade recept ===")
            print(innehall)
    except FileNotFoundError:
        print("Ingen receptfil hittades.")

def main():
    while True:
        print("\n1. Lägg till recept")
        print("2. Visa alla recept")
        print("3. Avsluta")
        val = input("Välj: ")

        if val == "1":
            namn = input("Ange receptnamn: ")
            ingredienser = []
            while True:
                ing = input("Lägg till ingrediens (eller tryck Enter för att avsluta): ")
                if ing == "":
                    break
                ingredienser.append(ing)
            spara_recept(namn, ingredienser)
            print("Recept sparat.")
        elif val == "2":
            las_recept()
        elif val == "3":
            break
        else:
            print("Ogiltigt val.")

main()
