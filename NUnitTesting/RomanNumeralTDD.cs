using NUnit.Framework;

namespace NUnitTesting
{
	public class RomanNumeralTDD
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
		public void RomainNumeralParserTest(int expected, string value)
		{
			//Assert.AreEqual(expected, RomanNumeralWithTDD.Parse(value));
			Assert.That(RomanNumeralWithTDD.Parse(value), Is.EqualTo(expected));
		}
	}
}
