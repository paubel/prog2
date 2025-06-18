from recipe import Recipe
from mealplanner import MealPlanner

# Skapa recept
pasta = Recipe("Pasta Bolognese")
pasta.add_ingredient("pasta", 300, "g")
pasta.add_ingredient("köttfärs", 400, "g")
pasta.add_ingredient("tomatsås", 2, "dl")

omelett = Recipe("Omelett")
omelett.add_ingredient("ägg", 3, "st")
omelett.add_ingredient("mjölk", 1, "dl")
omelett.add_ingredient("ost", 50, "g")

# Lägg till i planering
planner = MealPlanner()
planner.add_recipe(pasta)
planner.add_recipe(omelett)

# Visa data
planner.list_all_recipes()
pasta.list_ingredients()
omelett.list_ingredients()
planner.generate_shopping_list()
