using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Goblin 
    {
		//this is for makin the random nombers
		private static Random _rng = new Random();

		private int _hitPoints;
		private string _name;
		private bool _isDead;

		public int GetHitPoints() { return _hitPoints; }
		public int SetHitPoints(int hp) {
			_hitPoints = hp + _rng.Next(10);
			return _hitPoints;
		}

		public string GetName() { return _name; }
		public string SetName(string name) { _name = name; return _name; }

		public bool IsDead() { return _isDead; }

		public void Attack(Goblin enemy)
		{
			int damage = _rng.Next(1,10);
			enemy.Hit(damage);
			Console.WriteLine($"{_name} attacks for {damage}.  {enemy.GetName()} has {enemy.GetHitPoints()} left");
		}

		private void Hit(int damage)
		{
			_hitPoints -= damage;
			if (_hitPoints <= 0)
			{
				Console.WriteLine($"{_name} has died. RIP");
				_isDead = true;
			}
		}

	}
}
