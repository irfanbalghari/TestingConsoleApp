using System.Collections.Generic;

namespace TestingConsoleApp
{
	public class SecoundHighest
	{
		static public int getSecondHighest(List<int> list)
		{
			int secondHighest = 0;
			int Max = 0;
			foreach (var item in list)
			{
				if (item > Max)
				{
					secondHighest = Max;
					Max = item;
				}
				//else if (item > secondHighest)
				else if (item != Max && secondHighest < item)
				{
					secondHighest = item;
				}
			}
			return secondHighest;
		}

		// 2nd highest with build in methods 
		/*grades.Sort();
		int max = grades.Count;
		int result = grades[max - 2];
		return result;*/

		//int max = 0, result = 0;
		//int prevalue = 0;
		//int lengh = grades.Count;
		//	for (int i = 0; i<lengh - 1; i++)
		//	{
		//		for (int j = 0; j<lengh - i - 1; j++)
		//		{
		//			if (grades[j] > grades[j + 1])
		//			{
		//				int temp = grades[j];
		//				grades[j] = grades[j + 1];
		//				grades[j + 1] = temp;
		//			//	(grades[j + 1], grades[i]) = (grades[i], grades[j + 1]);
		//					}
		//}
		//			}
		//			return grades[lengh - 2];
	}
}
