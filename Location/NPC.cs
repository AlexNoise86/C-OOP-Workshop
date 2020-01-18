using System;

namespace OOPGame
{
	public class NPC : GameObject
	{
		public NPC()
		{
			
		}

		public NPC(string name, Position position, ConsoleColor color)
			:base(name, position, color)
		{

		}
	}
}
