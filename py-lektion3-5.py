# Del 1 – Arv & Polymorfism: Djurläten
class Animal:
    def speak(self):
        print("Djuret låter.")

class Dog(Animal):
    def speak(self):
        print("Hunden säger voff.")

class Cat(Animal):
    def speak(self):
        print("Katten säger mjau.")

class Bird(Animal):
    def speak(self):
        print("Fågeln kvittrar.")

# Del 2 – Geometriska former
class Shape:
    def area(self):
        return 0

class Rectangle(Shape):
    def __init__(self, w, h):
        self.w = w
        self.h = h
    def area(self):
        return self.w * self.h

class Circle(Shape):
    def __init__(self, r):
        self.r = r
    def area(self):
        return 3.14 * self.r ** 2

# Del 3 – Person & Student med super()
class Person:
    def __init__(self, name):
        self.name = name
    def introduce(self):
        print(f"Jag heter {self.name}.")

class Student(Person):
    def __init__(self, name, school):
        super().__init__(name)
        self.school = school
    def introduce(self):
        super().introduce()
        print(f"Jag går på {self.school}.")

# Huvudmeny
def main():
    while True:
        print("\n--- HUVUDMENY ---")
        print("1. Djurläten (polymorfism)")
        print("2. Area för former")
        print("3. Introduktion med super()")
        print("4. Avsluta")

        choice = input("Välj ett alternativ (1–4): ")

        if choice == "1":
            animals = [Dog(), Cat(), Bird(), Animal()]
            for a in animals:
                a.speak()

        elif choice == "2":
            shapes = [Rectangle(4, 5), Circle(3)]
            for s in shapes:
                print("Area:", s.area())

        elif choice == "3":
            name = input("Ange namn: ")
            school = input("Ange skola: ")
            student = Student(name, school)
            student.introduce()

        elif choice == "4":
            print("Avslutar programmet.")
            break
        else:
            print("Ogiltigt val, försök igen.")

main()
