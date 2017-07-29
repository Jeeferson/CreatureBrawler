using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fantastical_Deathmatch
{
	public class Program
	{
		static void Main(string[] args)
		{
		    Goblin g1 = new Goblin();

			g1.SetName("Grobgar the Destroyer");
			g1.SetHitPoints(40);

			Goblin g2 = new Goblin();

			g2.SetName("Xanzar the Dragonstabber");
			g2.SetHitPoints(40);
			Random _rng = new Random();
			int coinflip = _rng.Next(1,2);

			while (g1.IsDead() == false && g2.IsDead() == false)
			{
				Thread.Sleep(3000);
				Console.Clear();
				if (coinflip == 1) { g1.Attack(g2); coinflip = 2; }
				else { g2.Attack(g1); coinflip = 1; }
			}
			Console.WriteLine("And we have a winnnnnneerrrrr!");
			Console.ReadLine();
		}
	}
}
