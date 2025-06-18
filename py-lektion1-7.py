def hamta_namn_och_alder():
    namn = input("Vad heter du? ")
    while True:
        try:
            alder = int(input("Hur gammal är du? "))
            if alder < 0:
                print("Åldern kan inte vara negativ. Försök igen.")
                continue
            return namn, alder
        except ValueError:
            print("Du måste skriva ett heltal för ålder.")

def berakna_100_arsdag(namn, alder):
    from datetime import datetime
    nuvarande_ar = datetime.now().year
    fyller_100_ar = nuvarande_ar + (100 - alder)
    return f"{namn}, du fyller 100 år år {fyller_100_ar}."

def visa_meny():
    print("\nMENY:")
    print("1. Ange namn och ålder")
    print("2. Beräkna när du fyller 100 år")
    print("3. Avsluta")

def main():
    namn = None
    alder = None

    while True:
        visa_meny()
        val = input("Välj ett alternativ (1-3): ")

        if val == "1":
            namn, alder = hamta_namn_och_alder()
        elif val == "2":
            if namn is None or alder is None:
                print("Du måste först ange namn och ålder (val 1).")
            else:
                meddelande = berakna_100_arsdag(namn, alder)
                print(meddelande)
        elif val == "3":
            print("Programmet avslutas.")
            break
        else:
            print("Ogiltigt val, försök igen.")

# Kör programmet
if __name__ == "__main__":
    main()
