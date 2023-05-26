using System;
using System.Collections.Generic;

namespace TestingConsoleApp
{
	public class Program
	{

		static void Main(string[] args)
		{

			// modiler_fizzbuzz.fizzBuzz(15);
			// RomanNumerical.Parse("I");

			/* Delegate example 
			var video = new Video() { Title = "End 1" };
			var VideoEncoder = new VideoEncoder(); // publisher
			var mailService = new MailService(); // subscriber
			var messageService = new MessageService(); // subscriber
			VideoEncoder.VideoEncoded += mailService.onVideoEncoded;
			VideoEncoder.VideoEncoded += messageService.Message;
			VideoEncoder.Encode(video);
			*/
			// uses boxing DateTime timeValue = Convert.ToDateTime("01:00 PM");
			DateTime timeValue = DateTime.Parse("01:00 PM");
			Console.WriteLine(timeValue.ToString("HH:mm"));
			List<int> a = new()
			{
				7,
				71,
				67,
			};
			List<int> b = new()
			{
				8,
				71,
				99,
			};
			//Console.WriteLine("result: " + GradeRounding.gradingStudents(value));
			//Console.WriteLine("result: " + SecoundHighest.getSecondHighest(a));

			var result = compareTriplets.CompareTriplets(a, b);
			result.ForEach(x => Console.WriteLine("result: " + x));

			//DependencyInversionPrinciple.getStarted();
		}

	}
}



