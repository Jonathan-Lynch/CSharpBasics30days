using System;

namespace SuperVillian
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your Villian Name?");
			string villianName = Console.ReadLine();
			Console.WriteLine("What is your Power?");
			string villianPower = Console.ReadLine();
			Console.WriteLine("Who is your Nemisis?");
			string nemisis = Console.ReadLine();

			Console.WriteLine("Name: {0} | Power: {1} | Nemisis: {2}", villianName, villianPower, nemisis);
		}
	}
}
