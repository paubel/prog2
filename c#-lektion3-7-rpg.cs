using System;
using System.Collections.Generic;

// === Basklass för spelkaraktärer ===
abstract class Character
{
    public string Name { get; }
    public int HP { get; protected set; } // skyddad set = endast åtkomlig inifrån denna klass eller subklasser
    public int Attack { get; protected set; }

    public Character(string name, int hp, int attack)
    {
        Name = name;
        HP = hp;
        Attack = attack;
    }

    public bool IsAlive() => HP > 0;

    public virtual void TakeDamage(int amount)
    {
        HP -= amount;
        Console.WriteLine($"{Name} tar {amount} skada. HP kvar: {HP}");
    }

    public virtual void DealDamage(Character target)
    {
        Console.WriteLine($"{Name} attackerar {target.Name} med {Attack} i skada.");
        target.TakeDamage(Attack);
    }

    // 🔧 NYTT: metod för att öka HP, istället för att manipulera HP direkt
    public void Heal(int amount)
    {
        HP += amount;
        Console.WriteLine($"{Name} helas med {amount}. HP: {HP}");
    }
}

// === Spelarklass ===
class Player : Character
{
    public List<Item> Inventory { get; }

    public Player(string name) : base(name, 100, 15)
    {
        Inventory = new List<Item>();
    }

    public void UseItem(Item item)
    {
        if (Inventory.Contains(item))
        {
            item.Use(this);
            Inventory.Remove(item);
        }
    }
}

// === Fiendeklass ===
class Enemy : Character
{
    public Enemy(string name, int hp, int attack) : base(name, hp, attack) { }
}

// === Föremål som kan användas i strid ===
class Item
{
    public string Name { get; }
    private Action<Character> Effect;

    public Item(string name, Action<Character> effect)
    {
        Name = name;
        Effect = effect;
    }

    public void Use(Character target)
    {
        Console.WriteLine($"{target.Name} använder {Name}.");
        Effect(target); // exekverar t.ex. en Heal
    }
}

// === Program med stridssimulator ===
class Program
{
    static void Main()
    {
        Player hero = new Player("Arin");
        Enemy goblin = new Enemy("Goblin", 50, 10);

        // 🔧 ÄNDRAT: Använder nu Heal-metod istället för att manipulera HP direkt
        Item potion = new Item("Hälsodryck", target =>
        {
            target.Heal(20); // använder Heal() istället för target.HP += 20
        });

        hero.Inventory.Add(potion);

        int round = 1;
        while (hero.IsAlive() && goblin.IsAlive())
        {
            Console.WriteLine($"\n--- Runda {round} ---");
            hero.DealDamage(goblin);
            if (goblin.IsAlive()) goblin.DealDamage(hero);
            if (hero.HP < 40 && hero.Inventory.Contains(potion))
                hero.UseItem(potion);
            round++;
        }

        Console.WriteLine(hero.IsAlive()
            ? $"{hero.Name} besegrade {goblin.Name}!"
            : $"{hero.Name} förlorade mot {goblin.Name}...");
    }
}
