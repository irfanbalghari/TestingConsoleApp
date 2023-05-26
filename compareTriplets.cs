using System.Collections.Generic;

namespace TestingConsoleApp
{
	public static class compareTriplets
	{
		public static List<int> CompareTriplets(List<int> a, List<int> b)
		{
			int index = 0, bob = 0, alice = 0;
			static List<int> callCompare(int index, List<int> a, List<int> b, int alice, int bob)
			{
				if (index == a.Count)
				{
					return new List<int> { alice, bob };
				}
				if (a[index] > b[index])
				{
					alice++;
				}
				else if (a[index] < b[index])
				{
					bob++;
				}
				return callCompare(index += 1, a, b, bob, alice);
			}
			return callCompare(index, a, b, alice, bob); ;
		}



	}
}


//int alice = 0;
//int bob = 0;
//for (int i = 0; i < 3; i++)
//{
//	if (a[i] > b[i])
//	{
//		alice += 1;
//	}
//	else if (a[i] < b[i])
//	{
//		bob += 1;
//	}
//}