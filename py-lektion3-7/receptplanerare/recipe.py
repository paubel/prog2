from ingredient import Ingredient

class Recipe:
    def __init__(self, name):
        self.name = name
        self.ingredients = []
    def add_ingredient(self, name, amount, unit):
        ingredient = Ingredient(name, amount, unit)
        self.ingredients.append(ingredient)
    def list_ingredients(self):
        print(f"\nIngredienser i {self.name}:")
        for i in self.ingredients:
            print(f"- {i}")
