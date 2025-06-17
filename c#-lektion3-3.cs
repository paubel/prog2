using System;

class Car
{
    public string Brand;
    public int Year;

    // Konstruktor
    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    // Metod som använder objektets data
    public void Honk()
    {
        Console.WriteLine($"{Brand} från {Year} tutar!");
    }

    // Metod för att uppdatera bilens år
    public void UpdateYear(int newYear)
    {
        Year = newYear;
    }
}

class Program
{
    static void Main()
    {
        // Skapa ett objekt med konstruktor
        Car car1 = new Car("Volvo", 2020);

        // Anropa metoder
        car1.Honk();               // Volvo från 2020 tutar!
        car1.UpdateYear(2023);     // Uppdatera år
        car1.Honk();               // Volvo från 2023 tutar!

        // Extra exempel
        Car car2 = new Car("Tesla", 2022);
        car2.Honk();
    }
}
