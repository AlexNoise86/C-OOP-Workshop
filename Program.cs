using System;
using System.Collections.Generic;

namespace OOPGame
{
	class Program
	{
		static void Main(string[] args)
		{
			InitGame();
			Update();
		}

		static void InitGame()
		{
			Game.Player = new Player("Hero", new Position(5, 10, 2, 2), ConsoleColor.White);

			Game.Objects.Add(Game.Player);

			Game.Objects.Add(new NPC("Enemy 1", new Position(10, 10, 2, 2), ConsoleColor.Red));
			Game.Objects.Add(new NPC("Enemy 2", new Position(15, 10, 2, 2), ConsoleColor.Blue));
			Game.Objects.Add(new NPC("Enemy 3", new Position(25, 20, 2, 2), ConsoleColor.Yellow));
			Game.Objects.Add(new NPC("Enemy 4", new Position(35, 5, 2, 2), ConsoleColor.Green));
			Game.Objects.Add(new NPC("Enemy 5", new Position(40, 3, 2, 2), ConsoleColor.Magenta));

			Game.Player.Inventory.Add(new Potion("Estus", 50));
			Game.Player.Inventory.Add(new Potion("Health potion", 5));
			Game.Player.Inventory.Add(new Meal("Boiled eggs", 2));
			Game.Player.Inventory.Add(new Meal("Sweetroll", 10));
		}

		static void Update()
		{
			ConsoleKeyInfo e;

			while(Game.Play)
			{
				switch(Game.Mode)
				{
					case GameMode.Location:
						GraphicsController.Draw(Game.Objects);

						e = Console.ReadKey();

						LocationController.Controll(e);
						break;

					case GameMode.Inventory:

						if(Game.Player.Inventory.Count == 0)
						{
							InventoryController.Close();
							break;
						}

						GraphicsController.DrawInventory(Game.Player.Inventory);

						e = Console.ReadKey();

						InventoryController.Controll(e);
						break;

					case GameMode.Battle:

						break;
				}

				
			}
		}
	}
}