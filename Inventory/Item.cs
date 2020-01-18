using System;

namespace OOPGame
{
	public class Item
	{
		private string name;

		public Item(string name)
		{
			this.name = name;
		}

		public string Name
		{
			get
			{
				return this.name;
			}
		}
	}
}
