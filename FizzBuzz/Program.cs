using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int k = 0; k < 100; k++){
				if ((k % 3 == 0) && (k % 5 == 0))
				{
					Console.WriteLine("FizzBuzz!");
				}
				else if (k % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (k % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(k);
				}
			}
		}
	}
}
