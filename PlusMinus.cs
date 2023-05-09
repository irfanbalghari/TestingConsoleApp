using System;

class Program123
{
	static void PlusMinus(int[] arr)
	{
		int arrlen = arr.Length;
		int positive = 0, negative = 0, zero = 0;

		foreach (int num in arr)
		{
			if (num == 0)
			{
				zero++;
			}
			else if (num < 0)
			{
				negative++;
			}
			else
			{
				positive++;
			}
		}

		double positiveProportion = (double)positive / arrlen;
		double negativeProportion = (double)negative / arrlen;
		double zeroProportion = (double)zero / arrlen;

		Console.WriteLine(positiveProportion.ToString("F6"));
		Console.WriteLine(negativeProportion.ToString("F6"));
		Console.WriteLine(zeroProportion.ToString("F6"));
	}

	static void Main123(string[] args)
	{
		int[] arr = new int[] { 1, 2, 3, -1, -2, -3, 0, 0 };
		PlusMinus(arr);
	}
}
