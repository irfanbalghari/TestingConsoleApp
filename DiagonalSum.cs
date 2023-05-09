using System;
using System.Collections.Generic;

namespace TestingConsoleApp
{
	internal class DiagonalSum
	{
		public DiagonalSum()
		{
			int[,] OneToNine = new int[3, 3] {        /*0, 1, 2*/
                                    /*0*/ { 1, 2, 3 },
                                    /*1*/ { 4, 5, 6 },
                                    /*2*/ { 7, 8, 9 }
						 };
			// list create and initialize
			List<List<int>> myArray = new List<List<int>> {
					new List<int> {1, 2, -3},
					new List<int> {4, 5, 6},
					new List<int> {7, 8, -9}
				};

			var total = CalculateDiagonalTotal(myArray);

			Console.WriteLine(total);
		}
		private static long CalculateDiagonalTotal(List<List<int>> arr)
		{
			int ln = arr.Count;
			int ltrsum = 0;
			int rtlsum = 0;
			int totalSum = 0;
			if (ln > 0)
			{
				for (int i = 0; i < ln; i++)
				{
					for (int j = 0; j < ln; j++)
					{
						if (i == j)
						{
							ltrsum += arr[i][j];
						}
						if ((i + j) == ln - 1)
						{
							rtlsum += arr[i][j];
						}
					}
				}
				totalSum = Math.Abs(rtlsum - ltrsum);
			}
			return totalSum;
		}
	}
}
