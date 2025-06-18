# --- Dictionary-exempel ---

# Skapa en dictionary
person = {
    "name": "Alice",
    "age": 25,
    "city": "Stockholm"
}

# Åtkomst
print("Namn:", person["name"])

# Ändra ett värde
person["age"] = 26

# Lägg till nyckel-värde-par
person["email"] = "alice@example.com"

# Ta bort en nyckel
del person["city"]

# Loop genom dictionaryn
print("\nPersonens info:")
for key, value in person.items():
    print(f"{key}: {value}")

# --- Tuple-exempel ---

# Skapa en tuple
coordinates = (10, 20)

# Åtkomst via index
print("\nKoordinater:")
print("X:", coordinates[0])
print("Y:", coordinates[1])

# Använd tuple för att returnera flera värden
def get_user():
    return ("Bob", 30)

# Avpaketering
name, age = get_user()
print("\nAnvändare från funktion:")
print("Namn:", name)
print("Ålder:", age)

# Skillnad mot listor
my_list = [1, 2, 3]
my_tuple = (1, 2, 3)

print("\nÄndringsbar lista:")
my_list[0] = 10
print(my_list)

print("Oföränderlig tuple:")
# my_tuple[0] = 10  # Denna rad skulle ge ett fel
print(my_tuple)
