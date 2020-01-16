using System;

namespace OOPGame
{
	public class GameObject
	{
		private string name;

		private Position position;
		private ConsoleColor color;

		public string Name
		{
			get
			{
				return this.name;
			}
		}

		public Position Position
		{
			get 
			{
				return this.position;
			}
		}

		public ConsoleColor Color
		{
			get
			{
				return this.color;
			}
		}
	}
}
