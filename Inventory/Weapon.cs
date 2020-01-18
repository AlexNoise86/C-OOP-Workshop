using System;

namespace OOPGame
{
	public class Weapon : Item, IWearable
	{
		public Weapon(string name)
			:base(name)
		{

		}

		public void Wear(Player p)
		{

		}
	}
}
