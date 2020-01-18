using System;

namespace OOPGame
{
	public abstract class GameObject
	{
		public static char Symbol = '#';
		private string name;

		private Position position;
		private ConsoleColor color;

		private int hpFull;
		private int hp;

		public GameObject(string name, Position position, ConsoleColor color)
		{
			this.name = name;
			
			this.position = position;

			this.color = color;

			hpFull = 100;
			hp = hpFull;
		}

		public void Attack(GameObject obj)
		{
			obj.TakeDamage(10);
		}

		public void TakeDamage(int dmg)
		{
			this.hp -= dmg;

			if(hp <= 0)
			{
				Die();
			}
		}

		public void Die()
		{

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

		public void Heal(int val)
		{
			if(hp + val > hpFull)
			{
				val = val - (hp + val - hpFull);
			}

			hp += val;

			Console.WriteLine($"\n{name} healed {val} HP!");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

		public int HP 
		{
			get
			{
				return this.hp;
			}
		}

		public int HPFull
		{
			get
			{
				return this.hp;
			}
		}

		public string HPPercent
		{
			get
			{
				double p = this.hpFull / this.hp * 100;
				return $"{p}%";
			}
		}

		public string Health
		{
			get
			{
				return $"Health: {this.hp}/{this.hpFull} ({this.HPPercent})";
			}
		}

	}
}
