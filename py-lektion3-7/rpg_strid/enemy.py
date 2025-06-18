from character import Character
class Enemy(Character):
    def __init__(self, name, hp, attack):
        super().__init__(name, hp, attack)
