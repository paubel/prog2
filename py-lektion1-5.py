def for_loop_example():
    print("FOR-loop:")
    for i in range(5):
        print(f"Line {i}")

    total = 0
    for i in range(1, 6):
        total += i
    print(f"Sum: {total}")

def while_loop_example():
    print("\nWHILE-loop:")
    password = ""
    while password != "secret":
        password = input("Enter password: ")
    print("Access granted.")

def do_while_simulation():
    print("\nDO-WHILE-liknande loop:")
    while True:
        text = input("Enter 'yes' to continue: ")
        if text == "yes":
            break

def break_continue_example():
    print("\nBREAK och CONTINUE i for-loop:")
    for i in range(10):
        if i == 7:
            break
        if i % 2 == 0:
            continue
        print(i)

def print_menu():
    print("\nMeny:")
    print("1. Say hello")
    print("2. Exit")

def run():
    while True:
        print_menu()
        choice = input("Välj: ")
        if choice == "1":
            print("Hello!")
        elif choice == "2":
            print("Programmet avslutas.")
            break
        else:
            print("Ogiltigt val.")

# Huvudprogram
if __name__ == "__main__":
    for_loop_example()
    while_loop_example()
    do_while_simulation()
    break_continue_example()
    run()
