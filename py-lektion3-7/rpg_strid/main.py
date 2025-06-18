from player import Player
from enemy import Enemy
from item import Item

def heal(target):
    target.hp += 20
    print(f"{target.name} får 20 HP tillbaka. HP: {target.hp}")

# Start
hero = Player("Arin")
enemy = Enemy("Goblin", hp=50, attack=10)
potion = Item("Hälsodryck", heal)
hero.inventory.append(potion)

# Strid
rounds = 1
while hero.is_alive() and enemy.is_alive():
    print(f"\n--- Runda {rounds} ---")
    hero.deal_damage(enemy)
    if enemy.is_alive():
        enemy.deal_damage(hero)
    if hero.hp < 40 and potion in hero.inventory:
        hero.use_item(potion)
    rounds += 1

# Resultat
if hero.is_alive():
    print(f"\n{hero.name} besegrade {enemy.name}!")
else:
    print(f"\n{hero.name} förlorade mot {enemy.name}...")
