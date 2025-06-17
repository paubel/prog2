using System;
using System.Collections.Generic;

#region Exempel 1 – Djursläktet

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Djuret låter.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Hunden säger voff.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Katten säger mjau.");
    }
}

#endregion

#region Exempel 2 – Former med area

abstract class Shape
{
    public abstract double Area();
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public override double Area()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius;

    public Circle(double r)
    {
        Radius = r;
    }

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

#endregion

#region Exempel 3 – base och utökning

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Jag heter {Name}.");
    }
}

class Student : Person
{
    public string School;

    public Student(string name, string school) : base(name)
    {
        School = school;
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"Jag går på {School}.");
    }
}

#endregion

#region Exempel 4 – Generisk klass

class Box<T>
{
    public T Content;

    public Box(T content)
    {
        Content = content;
    }

    public void Show()
    {
        Console.WriteLine("Boxen innehåller: " + Content);
    }
}

#endregion

class Program
{
    static void Main()
    {
        // Exempel 1 – Djursläktet
        Console.WriteLine("=== Djursläktet ===");
        List<Animal> animals = new List<Animal> { new Dog(), new Cat() };
        foreach (Animal animal in animals)
        {
            animal.Speak();
        }

        // Exempel 2 – Former
        Console.WriteLine("\n=== Former och area ===");
        List<Shape> shapes = new List<Shape> { new Rectangle(4, 5), new Circle(3) };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Area: " + shape.Area());
        }

        // Exempel 3 – Person och Student
        Console.WriteLine("\n=== Person och Student ===");
        Person person = new Person("Maria");
        person.Introduce();

        Student student = new Student("Erik", "Teknikgymnasiet");
        student.Introduce();

        // Exempel 4 – Generisk klass
        Console.WriteLine("\n=== Generisk klass Box<T> ===");
        Box<int> numberBox = new Box<int>(42);
        Box<string> textBox = new Box<string>("Hej");
        numberBox.Show();
        textBox.Show();
    }
}
