using System;

namespace TestingConsoleApp
{
	class IndexerTest
	{
		private int[] Age = new int[5];
		public int this[int index]
		{
			get { return Age[index]; }
			set
			{
				if (value > 0)
				{
					if (index >= 0 && index < Age.Length)
					{
						Age[index] = value;
					}
					else
					{
						Console.WriteLine("invalid index");
					}
				}
				else
				{
					Console.WriteLine("invalid value");
				}

			}
		}

		// in main or call this by 
		//IndexerTest ag = new IndexerTest();
		//ag[0] = 50;
		//	ag[1] = 90;

		//	Console.WriteLine(ag[1]);
	}
}
