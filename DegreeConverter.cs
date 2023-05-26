using System;

namespace TestingConsoleApp
{
	public class DegreeConverter
	{
		public double ToFahrenheit(double celsius)
		{
			return Math.Truncate((celsius * 9 / 5) + 32);
		}
		public double ToCelsius(double fahrenheit)
		{
			return Math.Truncate((fahrenheit - 32) * 5 / 9);
		}

	}
}
