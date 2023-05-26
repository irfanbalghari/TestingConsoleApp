using System.Collections.Generic;
using System.Linq;

namespace TestingConsoleApp
{
	public class birthdayCakeCandles
	{
		public birthdayCakeCandles()
		{
			var result = birthdayCake(new List<int> { 1, 2, 7, 4, 7 });
		}
		public static int birthdayCake(List<int> arr)
		{
			int maxCount = 0;
			int len = arr.Count;
			int max = arr[0];
			//for (int i = 0; i < len; i++)
			//{
			//	if (arr[i] > max)
			//	{
			//		max = arr[i];
			//	}
			//}
			max = arr.Max();
			for (int i = 0; i < len; i++)
			{
				if (arr[i] == max)
				{

					maxCount++;
				}
			}
			return maxCount;
		}
	}
}
