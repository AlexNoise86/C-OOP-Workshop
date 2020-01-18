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

		public List<Item> Inventory
		{
			get
			{
				return this.inventory;
			}
		}
	}
}
