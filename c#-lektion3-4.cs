using System;

class BankAccount
{
    // Privat fält – kan inte nås direkt utanför klassen
    private decimal balance;

    // Publik egenskap – kontrollerar åtkomst
    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Fel: Saldo kan inte vara negativt.");
            }
        }
    }

    // Exempel på en endast-läsbar egenskap
    public string AccountType { get; } = "Privatkonto";
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        // Sätt ett giltigt saldo
        account.Balance = 500;
        Console.WriteLine($"Saldo: {account.Balance} kr"); // 500

        // Försök sätta ett negativt saldo
        account.Balance = -100; // Ignoreras
        Console.WriteLine($"Saldo: {account.Balance} kr"); // Fortfarande 500

        // Läs endast-läsbar egenskap
        Console.WriteLine($"Kontotyp: {account.AccountType}");
    }
}
