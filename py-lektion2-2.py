# Skapa en lista
fruits = ["apple", "banana", "cherry"]
print("Ursprunglig lista:", fruits)

# Läsa och ändra element
print("Första frukten:", fruits[0])  # Index 0
fruits[1] = "orange"
print("Efter ändring:", fruits)  # ['apple', 'orange', 'cherry']

# Lägga till element
fruits.append("pear")
fruits.insert(1, "kiwi")
print("Efter tillägg:", fruits)

# Ta bort element
fruits.remove("orange")
print("Efter borttagning:", fruits)

# Iterera med for
print("\nJag gillar dessa frukter:")
for fruit in fruits:
    print(f"I like {fruit}")

# Iterera med index
print("\nMed index:")
for i in range(len(fruits)):
    print(f"{i}: {fruits[i]}")

# Andra funktioner
numbers = [10, 20, 30]
print("\nNumbers:", numbers)
print("Summa:", sum(numbers))
print("Antal:", len(numbers))
print("Största talet:", max(numbers))

# Funktion som skriver ut en lista
def print_list(lst):
    print("\nSkriver ut lista:")
    for item in lst:
        print(item)

print_list(["car", "bike", "bus"])

# Funktion som returnerar jämna tal
def even_numbers(n):
    result = []
    for i in range(n):
        if i % 2 == 0:
            result.append(i)
    return result

print("\nJämna tal upp till 10:", even_numbers(10))
