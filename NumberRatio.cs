//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestingConsoleApp
//{
//	public class NumberRatio
//	{

//	}
//	static void class Main() {
////Console.WriteLine("Hello World!");

//			//int n = Convert.ToInt32(Console.ReadLine().Trim());
//			long int64;
//	List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//	Program.plusMinus(arr);

//			Console.Read();		

//}

//public static void plusMinus(List<int> arr)
//{

//	float positiveNumbers = 0;
//	float negativeNumbers = 0;
//	float Zeros = 0;

//	for (int i = 0; i < arr.Count; i++)
//	{
//		if (arr[i] > 0)
//		{
//			//positiveNumbers.Add(arr[i]);
//			positiveNumbers = positiveNumbers + 1;

//		}
//		else if (arr[i] < 0)
//		{
//			negativeNumbers = negativeNumbers + 1;
//		}
//		else
//		{
//			Zeros = Zeros + 1;
//		}
//	}
//	int total = arr.Count;
//	double pos = (positiveNumbers / total);
//	string positiveResult = pos.ToString("N6");
//	string negResult = (negativeNumbers / total).ToString("N6");
//	string ZeroResult = (Zeros / total).ToString("N6");
//	Console.WriteLine("positive: " + positiveResult);
//	Console.WriteLine("negative: " + negResult);
//	Console.WriteLine("Zeros: " + ZeroResult);

//	//Console.WriteLine(arr[0]);

//}
//}
