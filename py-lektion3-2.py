# Klassdefinition
class Book:
    def __init__(self, title, author):
        self.title = title
        self.author = author

    def print_info(self):
        print(f"{self.title} av {self.author}")

# Exempelanvändning
def main():
    # Skapa tre böcker
    book1 = Book("1984", "George Orwell")
    book2 = Book("Frankenstein", "Mary Shelley")
    book3 = Book("Möss och människor", "John Steinbeck")

    # Skriv ut information om varje bok
    print("Böcker i biblioteket:")
    book1.print_info()
    book2.print_info()
    book3.print_info()

if __name__ == "__main__":
    main()
