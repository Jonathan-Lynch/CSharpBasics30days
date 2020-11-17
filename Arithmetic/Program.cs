using System;

namespace Arithmetic
{
	class Program
	{
		static void Main(string[] args)
		{
			addition();
			subtraction();
			multiplacation();
			division();
		}

		static void addition()
		{
			Console.WriteLine("Write a number.");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write another number.");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int sum = num1 + num2;

			Console.WriteLine("The Sum of those numbers are {0}", sum);
		}

		static void subtraction()
		{
			Console.WriteLine("Write a number.");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write another number.");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int sum = num1 - num2;

			Console.WriteLine("The Sum of those numbers are {0}", sum);
		}

		static void multiplacation()
		{
			Console.WriteLine("Write a number.");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write another number.");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int sum = num1 * num2;

			Console.WriteLine("The Sum of those numbers are {0}", sum);
		}

		static void division()
		{
			Console.WriteLine("Write a number.");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Write another number.");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int sum = num1 / num2;

			Console.WriteLine("The Sum of those numbers are {0}", sum);
		}
	}
}
