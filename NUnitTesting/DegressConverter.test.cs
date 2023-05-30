using NUnit.Framework;
using TestingConsoleApp;

namespace NUnitTesting
{
	[TestFixture]
	public class DegressConverter
	{
		[Test]
		[TestCase(90, 32)]
		[TestCase(36, 2)]
		[TestCase(1, -17)]
		public void Fahrenheit_ShouldConvertTo_DegreeCelsius(double value, double expected)
		{
			var sut = new DegreeConverter();

			double result = sut.ToCelsius(value);
			Assert.That(result, Is.EqualTo(expected));
		}
		[Test]
		public void DegreeCelsius_ShouldConvertTo_Fahrenheit()
		{
			var sut = new DegreeConverter();
			double result1 = sut.ToFahrenheit(0);
			Assert.That(result1, Is.EqualTo(32));

		}
	}
}
