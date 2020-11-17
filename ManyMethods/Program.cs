using System;

namespace ManyMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Hello();
			addition();
		}

		static void Hello()
		{
			Console.WriteLine("Hello! What is your name?");
			string name = Console.ReadLine();
			Console.WriteLine("Goodbye {0}!", name);
		}

		static void addition()
		{
			Console.WriteLine("Enter a number");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write another number");
			int num2 = Convert.ToInt32(Console.ReadLine());
			int sum = num1 + num2;
			Console.WriteLine("The Total of both numbers are {0}", sum);
		}
	}
}
