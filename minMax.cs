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
			//used these for test passing;
			//long minSum = long.MaxValue, maxSum = long.MinValue;
			//minSum = Math.Min(minSum, sum);
			//maxSum = Math.Max(maxSum, sum);

			long max = 0;
			long min = 0;
			int len = arr.Count;
			for (int a = 0; a < len; a++)
			{
				int tempTotal = 0;
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
			// using linq but in this case failing overflow
			//var arr2 = new List<int> { 89, 7, 99, 4, 0 };
			//arr2.Sort();
			//long mnSum = arr2.Take(4).Sum();
			//long mxSum = arr2.Skip(1).Sum();
		}
	}

}
