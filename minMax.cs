using System;
using System.Collections.Generic;

namespace TestingConsoleApp
{
	class Program1
	{
		//static void ()
		//{
		//List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

		//   miniMaxSum(arr);
		//	}


		public static void miniMaxSum(List<int> arr)
		{
			long max = 0;
			long min = 0;
			int len = arr.Count;
			for (int a = 0; a < len; a++)
			{
				long tempTotal = 0;
				for (int b = 0; b < len; b++)
				{
					if (a != b)
					{
						tempTotal = tempTotal + arr[b];
					}
				}
				if (tempTotal > max)
				{
					max = tempTotal;
				}
				else
				{
					min = tempTotal;
				}

			}
			Console.WriteLine(min + " " + max);
		}
	}

}
