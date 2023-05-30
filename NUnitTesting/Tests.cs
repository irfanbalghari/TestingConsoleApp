using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestingConsoleApp;

namespace NUnitTesting
{
	[TestFixture]
	public class Tests
	{
		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(5, "V")]
		[TestCase(4, "IV")]
		[TestCase(10, "X")]
		[TestCase(49, "XLIX")]
		[TestCase(50, "L")]
		[TestCase(55, "LV")]
		[TestCase(100, "C")]
		[TestCase(500, "D")]
		[TestCase(1000, "M")]
		[TestCase(1995, "MCMXCV")]
		[TestCase(2018, "MMXVIII")]
		[TestCase(2023, "MMXXIII")]
		public void RomanNumberparser_test(int expected, string number)
		{
			Assert.AreEqual(expected, RomanNumerical.Parse(number));
		}

		[Test]
		public void Push_PuchOneItemToStack_shouldAddOne()
		{
			var stack = new Stack<int>();

			stack.Push(1);
			Assert.AreEqual(1, stack.Count);
			stack.Pop();
			Assert.IsTrue(stack.Count == 0);
			stack.Push(1);
			stack.Peek();
			Assert.AreEqual(1, stack.Count);
		}

		[Test]
		public void AddNumber_ValidValues_ReturnsCorrectResults()
		{
			var sut = new Calculator();
			var result = sut.AddNumber(1, 2);
			Assert.That(result, Is.EqualTo(3));
		}
		[Test]
		public void IsOddNumber_InputEvenNumber_ReturnsFalse()
		{
			// Arrange 
			var sut = new Calculator();
			//var result = sut.IsOddNumber(1); // odd number
			// Act
			var result = sut.IsOddNumber(2); // even number
											 // Assert
			Assert.That(result, Is.EqualTo(false));
			Assert.IsFalse(result);
		}

		// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
		//[TestCase(0, 0)]
		//[TestCase(1, 1)]
		//[TestCase(1, 2)]
		//[TestCase(2, 3)]
		//[TestCase(3, 4)]
		[TestCase(5, 5)]
		//[TestCase(8, 6)]
		//[TestCase(13, 7)]
		//[TestCase(21, 8)]
		//[TestCase(34, 9)]
		public void TestFibonacciNumbers(int expected, int index)
		{
			Assert.AreEqual(expected, GetFibonacci(index));
		}

		private int GetFibonacci(int index)
		{
			if (index == 0)
			{
				return 0;
			}
			if (index == 1)
			{
				return 1;
			}
			//var num1 = GetFibonacci(index - 1);
			//var num2 = GetFibonacci(index - 2);
			//var result = num1 + num2;
			//return result;
			var a = GetFibonacci(index - 1);
			Console.WriteLine("index: " + index + "a: " + a);
			var b = GetFibonacci(index - 2);
			Console.WriteLine("index: " + index + "b: " + b);
			return a + b;
		}
		// fizzBuzzTDD
		[TestCase("Fizz", 3)]
		[TestCase("", 4)]
		[TestCase("Buzz", 5)]
		[TestCase("Fizz", 6)]
		[TestCase("", 7)]
		[TestCase("Buzz", 10)]
		[TestCase("FizzBuzz", 15)]
		public void FizzBuzzTest(string expected, int value)
		{
			Assert.AreEqual(expected, FizzBuzz(value));
		}

		private string FizzBuzz(int value)
		{
			if (value % 3 == 0 && value % 5 == 0)
			{
				return "FizzBuzz";
			}
			if (value % 3 == 0)
			{
				return "Fizz";
			}
			if (value % 5 == 0)
			{
				return "Buzz";
			}
			return "";
		}

		[Test]
		public void CombineName_InputFirstAndLastName_ReturnFullName()
		{
			//Arrange
			Customer customer = new();

			//to check null 
			Assert.IsNull(customer.GreetMessage);

			//Act
			customer.GreetAndCombineNames("Ben", "Spark");
			Assert.Multiple(() =>
			{
				Assert.AreEqual(customer.GreetMessage, "Hello, Ben Spark");
				Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
				Assert.That(customer.GreetMessage, Does.Contain("ben Spark").IgnoreCase);
				Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
				Assert.That(customer.GreetMessage, Does.EndWith("Spark"));
				Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
			});
			//Assert

		}
		class Customer
		{
			public string GreetMessage { get; set; }
			public string GreetAndCombineNames(string firstName, string lastName)
			{
				GreetMessage = $"Hello, {firstName} {lastName}";
				return GreetMessage;
			}
		}
	}
}
