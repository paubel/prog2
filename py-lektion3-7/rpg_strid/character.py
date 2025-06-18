class Character:
    def __init__(self, name, hp, attack):
        self.name = name
        self.hp = hp
        self.attack = attack
    def is_alive(self):
        return self.hp > 0
    def take_damage(self, amount):
        self.hp -= amount
        print(f"{self.name} tar {amount} skada. HP kvar: {self.hp}")
    def deal_damage(self, target):
        print(f"{self.name} attackerar {target.name} med {self.attack} i skada.")
        target.take_damage(self.attack)
