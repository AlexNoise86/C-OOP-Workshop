using System;

namespace OOPGame
{
	public class Meal : Item, IUsable
	{
		private int hpVal;

		public Meal(string name, int hpVal)
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
				return $"Delicious {this.Name} restores {this.hpVal} HP.";
			}
		}
	}
}
