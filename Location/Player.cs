using System;
using System.Collections.Generic;

namespace OOPGame
{
	public class Player : GameObject
	{

		private List<Item> inventory;

		public Player(string name, Position position, ConsoleColor color)
			:base(name, position, color)
		{
			inventory = new List<Item>();
		}

		public void Use(int index)
		{
			if(inventory[index] is IUsable)
			{
				IUsable item = inventory[index] as IUsable;
				item.Use(this);

				inventory.RemoveAt(index);
			}
			else
			{
				Console.WriteLine("You can't use that!");
			}
		}

		public List<Item> Inventory
		{
			get
			{
				return this.inventory;
			}
		}
	}
}
