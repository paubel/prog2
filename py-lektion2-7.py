def add_book(catalog):
    title = input("Titel: ")
    author = input("Författare: ")
    year = input("År: ")
    book = {"title": title, "author": author, "year": year}
    catalog.append(book)

def search_books(catalog):
    query = input("Sök titel eller författare: ").lower()
    found = [book for book in catalog if query in book["title"].lower() or query in book["author"].lower()]
    if found:
        print("\nSökresultat:")
        for book in found:
            print(f"{book['title']} av {book['author']} ({book['year']})")
    else:
        print("Inga böcker hittades.")

def print_catalog(catalog):
    if not catalog:
        print("Inga böcker i katalogen.")
        return
    sorted_books = sorted(catalog, key=lambda x: x["title"])
    print("\nBokkatalog:")
    for book in sorted_books:
        print(f"{book['title']} av {book['author']} ({book['year']})")

def main():
    catalog = []
    while True:
        print("\n--- Bokkatalog ---")
        print("1. Lägg till bok")
        print("2. Sök bok")
        print("3. Visa alla")
        print("4. Avsluta")
        choice = input("Välj: ")
        if choice == "1":
            add_book(catalog)
        elif choice == "2":
            search_books(catalog)
        elif choice == "3":
            print_catalog(catalog)
        elif choice == "4":
            print("Programmet avslutas.")
            break
        else:
            print("Ogiltigt val. Försök igen.")

if __name__ == "__main__":
    main()
