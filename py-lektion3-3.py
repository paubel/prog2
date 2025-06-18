class Car:
    def __init__(self, brand, year):
        self.brand = brand
        self.year = year

    def honk(self):
        print(f"{self.brand} från {self.year} tutar!")

    def change_year(self, new_year):
        self.year = new_year
        print(f"Årsmodellen har ändrats till {self.year}.")

# Exempelanvändning
def main():
    car1 = Car("Volvo", 2020)
    car1.honk()  # Skriver ut: Volvo från 2020 tutar!

    car1.change_year(2023)  # Ändrar årsmodell
    car1.honk()  # Skriver ut: Volvo från 2023 tutar!

if __name__ == "__main__":
    main()
