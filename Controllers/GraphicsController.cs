using System;
using System.Collections.Generic;

namespace OOPGame
{
	public static class GraphicsController
	{
		public static string TopLine = "";
		public static string MidLine = "";

		public static void Draw(List<GameObject> objects)
		{
			Console.Clear();

			DrawBorder();

			foreach(GameObject obj in objects)
			{
				if(obj.HP > 0)
				{
					Draw(obj);
				}
			}

			Console.SetCursorPosition(0, Game.Height + 1);
		}

		public static void Draw(GameObject obj)
		{
			Console.SetCursorPosition(obj.Position.X - obj.Position.WidthHalf, obj.Position.Y - obj.Position.HeightHalf);
			Console.ForegroundColor = obj.Color;

			string width = "";

			char symbol = ' ';

			switch(obj.Position.Direction)
			{
				case Direction.Up:
					symbol = '↑';
					break;

				case Direction.Down:
					symbol = '↓';
					break;

				case Direction.Left:
					symbol = '←';	
					break;

				case Direction.Right:
					symbol = '→';
					break;
			}

			for(int i = 0; i < obj.Position.Width; i++)
			{

				width += symbol;
			}

			for(int i = 0; i < obj.Position.Height; i++)
			{
				Console.SetCursorPosition(obj.Position.X - obj.Position.WidthHalf, obj.Position.Y - obj.Position.HeightHalf + i);
				Console.Write(width);
			}
		}

		public static void DrawInventory(List<Item> items)
		{
			Console.Clear();

			Console.SetCursorPosition(0, 0);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Inventory");

			for(int i = 0; i < items.Count; i++)
			{
				Console.ForegroundColor = ConsoleColor.Gray;

				if(i == Game.Selection)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
				}

				Console.WriteLine(items[i].Name);
			}

			Console.ForegroundColor = ConsoleColor.Gray;
		}

		public static void DrawBattle()
		{
			
		}

		public static void DrawBorder()
		{
			Console.ForegroundColor = ConsoleColor.White;

			InitLines();

			for(int i = 0; i < Game.Height; i++)
			{
				if(i == 0 || i == Game.Height - 1)
				{
					Console.WriteLine(TopLine);
				}
				else
				{
					Console.WriteLine(MidLine);
				}
			}
		}

		private static void InitLines()
		{
			if(TopLine == "")
			{
				for(int i = 0; i < Game.Width; i++)
				{
					if(i == 0 || i == Game.Width - 1)
					{
						TopLine += "+";
						MidLine += "|";
					}
					else
					{
						TopLine += "=";
						MidLine += " ";
					}
				}
			}
		}

	}
}