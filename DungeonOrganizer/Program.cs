using DungeonOrganizer.Characters;
using DungeonOrganizer.Items;
using DungeonOrganizer.UI;
using DungeonOrganizer.World;

using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InventoryItem invItem = new InventoryItem("Mikstura", 15);
Weapon weapon = new Weapon("Miecz", 8);
MapItem mapItem = new MapItem("!");

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);
GamePrinter.ShowInvItem(invItem.Name, invItem.Price);
GamePrinter.ShowMapItem(mapItem.Symbol);