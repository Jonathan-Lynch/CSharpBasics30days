using System;

namespace SuperHeroes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your Super Hero name?");
			string superName = Console.ReadLine();
			Console.WriteLine("What is your Super Power");
			string superPower = Console.ReadLine();
			Console.WriteLine("SuperHero: " + superName + " | " + "Power: " + superPower);
		}
	}
}
