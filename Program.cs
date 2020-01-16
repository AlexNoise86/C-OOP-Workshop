using System;
using System.Collections.Generic;

namespace OOPGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Game.Player = new Player("Hero", new Position(5, 10, 2, 2), ConsoleColor.Green);

			Game.Objects.Add(Game.Player);


			while(true)
			{
				Graphics.Draw(Game.Objects);

				ConsoleKeyInfo e = Console.ReadKey();

				if(e.Key == ConsoleKey.Escape) break;

				Controller.Controll(e);
			}
			
		}
	}
}