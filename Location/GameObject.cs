using System;

namespace OOPGame
{
	public class GameObject
	{
		public static char Symbol = '#';
		private string name;

		private Position position;
		private ConsoleColor color;

		public GameObject(string name, Position position, ConsoleColor color)
		{
			this.name = name;
			
			this.position = position;

			this.color = color;
		}

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
