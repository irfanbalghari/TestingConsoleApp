namespace TestingConsoleApp
{
	public class Sorting
	{
		public static void bubbleSort(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						// swap arr[j] and arr[j+1]

						//int temp = arr[j];
						//arr[j] = arr[j + 1];
						//arr[j + 1] = temp;
						// using tuple
						(arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
					}
				}
			}
			//return arr;
		}
		public static void InsertionSort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				int key = arr[i];
				int j = i - 1;

				while (j >= 0 && arr[j] > key)
				{
					arr[j + 1] = arr[j];
					j--;
				}

				arr[j + 1] = key;
			}
		}


	}
}
