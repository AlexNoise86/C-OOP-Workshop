﻿using System;
using System.Collections.Generic;

namespace OOPGame
{
	class Program
	{
		static void Main(string[] args)
		{
			InitGame();
			Update();
		}

		static void InitGame()
		{
			Game.Player = new Player("Hero", new Position(5, 10, 2, 2), ConsoleColor.Blue);

			Game.Objects.Add(Game.Player);

			Game.Objects.Add(new NPC("Enemy 1", new Position(10, 10, 2, 2), ConsoleColor.Red));
			Game.Objects.Add(new NPC("Enemy 2", new Position(15, 10, 2, 2), ConsoleColor.Red));
			Game.Objects.Add(new NPC("Friend 1", new Position(20, 10, 2, 2), ConsoleColor.Green));
			Game.Objects.Add(new NPC("Friend 2", new Position(10, 20, 2, 2), ConsoleColor.Green));
		}

		static void Update()
		{
			bool play = true;

			while(play)
			{


				switch(Game.GameMode)
				{
					case GameMode.Location:
						Graphics.Draw(Game.Objects);

						ConsoleKeyInfo e = Console.ReadKey();

						if(e.Key == ConsoleKey.Escape) play = false;

						Controller.Controll(e);
						break;

					case GameMode.Inventory:
						Graphics.DrawInventory();

						Console.ReadLine();
						break;

					case GameMode.Battle:

						break;
				}

				
			}
		}
	}
}