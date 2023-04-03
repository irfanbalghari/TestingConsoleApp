using System;

namespace TestingConsoleApp
{
	public class modiler_fizzbuzz
	{
		public static string fizzBuzz(int i)
		{
			//int i = 1;
			//while (i <= n)
			//{
			//	i++;
			if ((i % 3) == 0 && (i % 5) == 0)
			{
				Console.WriteLine("FizzBuzz");
				return "FizzBuzz";
			}
			else if ((i % 3) == 0)
			{
				Console.WriteLine("Fizz");
				return "Fizz";
			}
			else if ((i % 5) == 0)
			{
				Console.WriteLine("Buzz");
				return "Buzz";
			}
			else
			{
				Console.WriteLine(i);
				return "";
			}

			//}
			//return null;
		}
	}
}
