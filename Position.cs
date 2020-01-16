using System;
using System.Collections.Generic;

namespace OOPGame
{
	public class Position
	{
		private int x;
		private int y;
		private int width;
		private int height;

		public Position(int x, int y, int width, int height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		public bool Move(Direction d)
		{
			int dX = 0;
			int dY = 0;

			switch(d)
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

			int tempX = x + dX;
			int tempY = y + dY;

			bool collided = Collide(Game.Objects, tempX, tempY);

			if(collided)
			{
				return false;
			}
			else
			{
				this.x = tempX;
				this.y = tempY;

				return true;
			}
		}

		public bool Collide(List<GameObject> objects, int tempX, int tempY)
		{
			bool collided = false;

			foreach(GameObject obj in objects)
			{
				if(Collide(obj.Position, tempX, tempY))
				{
					collided = true;
					break;
				}
			}

			return collided;
		}

		public bool Collide(Position obj, int tempX, int tempY)
		{
			bool collided = false;

			if(
				tempX > obj.X 
				)
			{

			}

			return collided;
		}

		public int X
		{
			get 
			{
				return this.x;
			}
		}

		public int Y
		{
			get 
			{
				return this.y;
			}
		}

		public int Width
		{
			get
			{
				return this.width;
			}
		}

		public int Height
		{
			get
			{
				return this.height;
			}
		}
	}
}