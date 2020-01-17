using System;
using System.Collections.Generic;

namespace OOPGame
{
	public static class Graphics
	{
		public static string TopLine = "";
		public static string MidLine = "";

		public static void Draw(List<GameObject> objects)
		{
			Console.Clear();

			DrawBorder();

			foreach(GameObject obj in objects)
			{
				Draw(obj);
			}

			Console.SetCursorPosition(0, Game.Height + 1);
		}

		public static void Draw(GameObject obj)
		{
			Console.SetCursorPosition(obj.Position.X - obj.Position.WidthHalf, obj.Position.Y - obj.Position.HeightHalf);
			Console.ForegroundColor = obj.Color;

			string width = "";

			for(int i = 0; i < obj.Position.Width; i++)
			{
				width += GameObject.Symbol;
			}

			for(int i = 0; i < obj.Position.Height; i++)
			{
				Console.SetCursorPosition(obj.Position.X - obj.Position.WidthHalf, obj.Position.Y - obj.Position.HeightHalf + i);
				Console.Write(width);
			}
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