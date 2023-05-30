using NUnit.Framework;
using System.Collections.Generic;
using TestingConsoleApp.SparkyLearnUnitTest;

namespace NUnitTesting
{
	[TestFixture]
	public class SparkyUnitTests
	{
		private GradingCalculator grade;
		[SetUp]
		public void SetUp()
		{
			grade = new();
		}
		#region Grading Calculator
		[Test]
		public void CalculateGrade_WhenScore90AndAtten70_ShouldReturnA()
		{
			grade.Score = 95;
			grade.AttendancePercentage = 90;
			var result = grade.GetGrade();

			Assert.That(result, Is.EqualTo("A"));
			Assert.AreEqual("A", result);
		}
		[Test]
		public void CalculateGrade_WhenScore85AndAtten70_ShouldReturnB()
		{
			grade.Score = 85;
			grade.AttendancePercentage = 90;
			var result = grade.GetGrade();

			Assert.That(result, Is.EqualTo("B"));
		}
		[Test]
		public void CalculateGrade_WhenScore65AndAtten90_ShouldReturnB()
		{
			grade.Score = 65;
			grade.AttendancePercentage = 90;
			var result = grade.GetGrade();

			Assert.That(result, Is.EqualTo("C"));
		}
		[Test]
		public void CalculateGrade_WhenScore95AndAtten65_ShouldReturnB()
		{
			grade.Score = 95;
			grade.AttendancePercentage = 65;
			var result = grade.GetGrade();

			Assert.That(result, Is.EqualTo("B"));
		}

		[Test]
		[TestCase(95, 55)]
		[TestCase(65, 55)]
		[TestCase(50, 90)]
		public void CalculateGrade_FailureScenarios_ShouldReturnB(int score, int attendance)
		{
			grade.Score = score;
			grade.AttendancePercentage = attendance;
			var result = grade.GetGrade();
			Assert.That(result, Is.EqualTo("F"));
		}

		[Test]
		[TestCase(95, 90, ExpectedResult = "A")]
		[TestCase(85, 90, ExpectedResult = "B")]
		[TestCase(65, 90, ExpectedResult = "C")]
		[TestCase(95, 65, ExpectedResult = "B")]
		[TestCase(95, 55, ExpectedResult = "F")]
		[TestCase(65, 55, ExpectedResult = "F")]
		[TestCase(50, 90, ExpectedResult = "F")]
		public string CalculateGrade_AllGradeScenarios_ShouldReturnB(int score, int attendance)
		{
			grade.Score = score;
			grade.AttendancePercentage = attendance;

			return grade.GetGrade();

		}
		#endregion

		[Test]
		public void FiboCheck_WhenRange1_ReturnFibSeries()
		{
			Fibo fibo = new Fibo();
			List<int> expected = new() { 0 };
			fibo.Range = 1;
			var result = fibo.GetFiboSeries();
			Assert.NotNull(result);
			Assert.IsNotEmpty(result);
			Assert.That(result, Is.Ordered);
			Assert.That(result, Is.EquivalentTo(expected));

		}
		[Test]
		public void FiboCheck_WhenRange6_ReturnFibSeries()
		{
			// Arrange
			Fibo fibo = new Fibo();
			List<int> expected = new() { 0, 1, 1, 2, 3, 5 };

			fibo.Range = 6;
			// Act

			var result = fibo.GetFiboSeries();
			//Assert
			Assert.Multiple(() =>
			{
				Assert.IsNotEmpty(result);
				Assert.That(result, Is.Ordered);
				Assert.That(result, Does.Contain(3));
				Assert.That(result, Has.No.Member(4));
				Assert.That(result, Is.EquivalentTo(expected));

			});

		}
	}


}
