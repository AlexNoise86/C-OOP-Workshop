using System;

namespace OOPGame
{
	public class Potion : Item, IUsable
	{
		private int hpVal;

		public Potion(string name, int hpVal)
			:base(name)
		{
			this.hpVal = hpVal;
		}

		public void Use(Player p)
		{
			p.Heal(hpVal);
		}

		public string Description
		{
			get
			{
				return $"A flask of {this.Name} restores {this.hpVal} HP.";
			}
		}
	}
}
