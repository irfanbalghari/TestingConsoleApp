using System.Collections.Generic;

namespace TestingConsoleApp
{
	static class compareTriplets
	{


		public static List<int> CompareTriplets(List<int> a, List<int> b)
		{
			List<int> result = new List<int>();
			int alice = 0;
			int bob = 0;

			for (int i = 0; i < 3; i++)
			{
				if (a[i] > b[i])
				{
					alice += 1;
				}
				else if (a[i] < b[i])
				{
					bob += 1;
				}
			}
			result.Add(alice);
			result.Add(bob);
			return result;
		}
	}
}
