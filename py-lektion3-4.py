class BankAccount:
    def __init__(self, owner, balance):
        self.owner = owner
        self._balance = balance  # "privat" attribut

    def deposit(self, amount):
        if amount > 0:
            self._balance += amount
            print(f"{amount} kr sattes in.")
        else:
            print("Beloppet måste vara positivt.")

    def withdraw(self, amount):
        if 0 < amount <= self._balance:
            self._balance -= amount
            print(f"{amount} kr togs ut.")
        else:
            print("Otillräckligt saldo eller ogiltigt belopp.")

    def get_balance(self):
        return self._balance


# Exempelanvändning
def main():
    account = BankAccount("Emma", 1000)
    account.deposit(500)       # In: 500
    account.withdraw(200)      # Ut: 200
    print(f"Saldo: {account.get_balance()} kr")  # Förväntat: 1300 kr

if __name__ == "__main__":
    main()
