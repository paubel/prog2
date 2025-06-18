class Ingredient:
    def __init__(self, name, amount, unit):
        self.name = name
        self.amount = amount
        self.unit = unit
    def __str__(self):
        return f"{self.amount} {self.unit} {self.name}"
