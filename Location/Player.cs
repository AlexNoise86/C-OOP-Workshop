using System;
using System.Collections.Generic;

namespace OOPGame
{
	public class Player : GameObject
	{
		private int hpFull;

		private int hp;

		private List<Item> inventory;

		public Player(string name, Position position, ConsoleColor color)
			:base(name, position, color)
		{
			inventory = new List<Item>();
			hpFull = 100;
			hp = hpFull;
		}

		public void Use(int index)
		{
			if(inventory[index] is IUsable)
			{
				IUsable item = inventory[index] as IUsable;
				item.Use(this);
			}
			else if(inventory[index] is IWearable)
			{
				IWearable item = inventory[index] as IWearable;
				item.Wear(this);
			}
			else
			{
				Console.WriteLine("You can't use that!");
			}
		}

		public void Heal(int val)
		{
			if(hp + val > hpFull)
			{
				val = val - (hp + val - hpFull);
			}

			hp += val;

			Console.WriteLine($"\nYou healed {val} HP!");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

		public int HP 
		{
			get
			{
				return this.hp;
			}
		}

		public int HPFull
		{
			get
			{
				return this.hp;
			}
		}

		public string HPPercent
		{
			get
			{
				double p = this.hpFull / this.hp * 100;
				return $"{p}%";
			}
		}

		public string Health
		{
			get
			{
				return $"Health: {this.hp}/{this.hpFull} ({this.HPPercent})";
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
