Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Ork", 45);
Inventory inventory = new Inventory();
Item potion = new Item("Mikstura", 15);
Item sword = new Item("Miecz", 40);

int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

inventory.Add(potion);
inventory.Add(sword);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);
inventory.InvPrinter();
inventory.CalculateValue();