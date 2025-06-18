from library import Library

lib = Library()
lib.add_book("1984", "George Orwell")
lib.add_book("Sagan om ringen", "J.R.R. Tolkien")
lib.register_member("Ali")
lib.register_member("Sara")

book1 = lib.find_book("1984")
book2 = lib.find_book("Sagan om ringen")
member = lib.find_member("Ali")

if book1 and member:
    member.borrow_book(book1)

if book2 and member:
    member.borrow_book(book2)

member.list_books()
member.return_book(book1)
member.list_books()
lib.list_books()
