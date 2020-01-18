using System;
using System.Collections.Generic;

namespace OOPGame
{
	public static class InventoryController
	{
		public static void Controll(ConsoleKeyInfo e)
		{
			switch(e.Key)
			{
				case ConsoleKey.UpArrow:

					
					break;

				case ConsoleKey.DownArrow:
					

					break;	
			}	

			
		}

		public static void Open()
		{
			if(Game.Player.Inventory.Count > 0)
			{
				Game.Mode = GameMode.Inventory;
				Game.Selection = 0;
			}
			else
			{
				Console.SetCursorPosition(0, Game.Height + 1);

				Console.WriteLine("Your inventory is empty! \nPress any key to continue...");
				Console.ReadKey();
			}
		}

		public static void Close()
		{
			Game.Selection = -1;
			Game.Mode = GameMode.Location;
		}

	}
}