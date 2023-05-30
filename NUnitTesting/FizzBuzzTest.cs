using NUnit.Framework;
using TestingConsoleApp;

namespace NUnitTesting
{
	public class FizzBuzzTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("Buzz", 5)]
		[TestCase("FizzBuzz", 15)]
		[TestCase("FizzBuzz", 30)]
		[TestCase("Fizz", 9)]
		public void TestFizzBuzz(string expected, int num)
		{
			//modiler_fizzbuzz fizzbuzz = new modiler_fizzbuzz();
			//var test = fizzbuzz.fizzBuzz(num);
			//Assert.Pass();
			Assert.AreEqual(expected, modiler_fizzbuzz.fizzBuzz(num));
		}
	}
}