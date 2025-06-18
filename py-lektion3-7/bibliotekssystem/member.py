class Member:
    def __init__(self, name):
        self.name = name
        self.borrowed_books = []

    def borrow_book(self, book):
        if book.borrow():
            self.borrowed_books.append(book)
            print(f"{self.name} lånade {book.title}.")
        else:
            print(f"{book.title} är redan utlånad.")

    def return_book(self, book):
        if book in self.borrowed_books:
            book.return_book()
            self.borrowed_books.remove(book)
            print(f"{self.name} lämnade tillbaka {book.title}.")
        else:
            print(f"{self.name} har inte {book.title}.")

    def list_books(self):
        if not self.borrowed_books:
            print(f"{self.name} har inga böcker.")
        else:
            print(f"{self.name} har lånat:")
            for book in self.borrowed_books:
                print(f"- {book}")
