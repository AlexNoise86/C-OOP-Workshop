using System;
using System.Collections.Generic;

namespace OOPGame
{
	public static class LocationController
	{
		public static void Controll(ConsoleKeyInfo e)
		{
			Direction d = Direction.None;

			switch(e.Key)
			{
				case ConsoleKey.UpArrow:
					d = Direction.Up;
					break;

				case ConsoleKey.DownArrow:
					d = Direction.Down;
					break;

				case ConsoleKey.LeftArrow:
					d = Direction.Left;
					break;

				case ConsoleKey.RightArrow:
					d = Direction.Right;
					break;

				case ConsoleKey.A:
					NPC obj = new NPC();

					int dY = 0;
					int dX = 0;

					switch(Game.Player.Position.Direction)
					{
						case Direction.Up:
							dY = -1;
							break;

						case Direction.Down:
							dY = 1;
							break;

						case Direction.Left:
							dX = -1;
							break;

						case Direction.Right:
							dX = 1;
							break;
					}

					int tempX = Game.Player.Position.X + dX;
					int tempY = Game.Player.Position.Y + dY;

					bool collided = Game.Player.Position.Collide(Game.Objects, tempX, tempY, obj);

					if(collided)
					{
						if(obj != null)
						{
							Game.Player.Attack(obj);
						}
					}
					break;

				case ConsoleKey.Escape:
					Console.SetCursorPosition(0, Game.Height + 1);
					Console.WriteLine("Are you sure you want to exit? (y/n)");

					e = Console.ReadKey();

					Console.WriteLine("\nGood Bye!");
					if(e.Key == ConsoleKey.Y)
					{
						Game.Play = false;
					}
					break;

				case ConsoleKey.I:
					InventoryController.Open();
					break;
			}			

			if(d != Direction.None)
			{
				Game.Player.Position.Move(d);
			}
		}

	}
}