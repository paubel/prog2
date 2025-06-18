class MealPlanner:
    def __init__(self):
        self.recipes = []
    def add_recipe(self, recipe):
        self.recipes.append(recipe)
    def list_all_recipes(self):
        print("\nTillgängliga recept:")
        for r in self.recipes:
            print(f"- {r.name}")
    def generate_shopping_list(self):
        print("\nInköpslista:")
        all_ingredients = {}
        for recipe in self.recipes:
            for i in recipe.ingredients:
                key = (i.name, i.unit)
                if key in all_ingredients:
                    all_ingredients[key] += i.amount
                else:
                    all_ingredients[key] = i.amount
        for (name, unit), amount in all_ingredients.items():
            print(f"- {amount} {unit} {name}")
