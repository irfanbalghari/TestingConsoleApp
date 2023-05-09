using System;

namespace TestingConsoleApp
{
	public class StairCase
	{
		StairCase()
		{
			int n = 6;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					int t = n - i;
					if (j < (n - (i + 1)))
						Console.Write(" ");
					else
					{
						Console.Write("#");
					}
				}
				Console.Write("\n");
			}
			Console.ReadLine();

		}
	}

	// one line solution in JS
	//for (let i = 1; i <= n; i++) console.log(" ".repeat(n - i) + "#".repeat(i));


	// another way
	//for (var c = 1; c <= total; c++)
	//{
	//	for (var x = 0; x < total; x++)
	//	{
	//		Console.Write(total - c <= x ? "#" : " ");
	//	}
	//	Console.WriteLine();
	//}

	//This will create a string with count number of spaces.
	//On the other hand, for the hash symbols, we need to create a string with a repeating
	//sequence of characters.In this case, it makes more sense to use String (or System.String)
	//because it has a static method called String.Concat() that can concatenate multiple strings
	//together efficiently.We can create a String with a repeating 
	//sequence of hash symbols using the constructor that takes a character and a count:
	// one line solution in #

	//for (int i = 1; i <= n; ++i)
	//{
	//	string output = new string(' ', n - i) + new String('#', i);
	//	Console.WriteLine(output);
	//}
}
