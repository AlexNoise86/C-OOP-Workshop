using System;
using System.Collections.Generic;

namespace OOPGame
{
	public static class Game
	{
		public static bool Play = true;

		public static List<GameObject> Objects = new List<GameObject>();
		public static Player Player;

		public const int Width = 100;
		public const int Height = 25; 

		public static GameMode Mode = GameMode.Location;

		public static int Selection = -1;	
	}
}