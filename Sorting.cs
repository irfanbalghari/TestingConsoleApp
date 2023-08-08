namespace TestingConsoleApp
{
    public class Sorting
    {
        public static void bubbleSort(int[] arr)
        {
            //int n = arr.Length;
            //for (int i = 0; i < n - 1; i++)
            //{
            //	for (int j = 0; j < n - i - 1; j++)
            //	{
            //		if (arr[j] > arr[j + 1])
            //		{
            //			// swap arr[j] and arr[j+1]

            //			//int temp = arr[j];
            //			//arr[j] = arr[j + 1];
            //			//arr[j + 1] = temp;
            //			// using tuple
            //			(arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
            //		}
            //	}
            //}
            //return arr;

            // Create an array of integers.
            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5 };

            // Sort the array in ascending order.
            int temp;
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;

                        (intArray[j], intArray[i]) = (intArray[i], intArray[j]);
                    }
                }
            }

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
