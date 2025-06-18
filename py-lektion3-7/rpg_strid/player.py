from character import Character
class Player(Character):
    def __init__(self, name):
        super().__init__(name, hp=100, attack=15)
        self.inventory = []
    def use_item(self, item):
        if item in self.inventory:
            item.use(self)
            self.inventory.remove(item)
