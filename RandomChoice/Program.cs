using System;

namespace RandomChoice
{
	class Program
	{
		static void Main(string[] args)
		{
			int randomInt;
			Random random = new Random();
			randomInt = random.Next(1, 7);

			switch(randomInt) {
				case 1:
					Console.WriteLine("James!");
					break;
				case 2:
					Console.WriteLine("Steven!");
					break;
				case 3:
					Console.WriteLine("Jacob!");
					break;
				case 4:
					Console.WriteLine("Jonathan!");
					break;
				case 5:
					Console.WriteLine("Caitlin!");
					break;
				case 6:
					Console.WriteLine("Daniel!");
					break;
			}
		}
	}
}
