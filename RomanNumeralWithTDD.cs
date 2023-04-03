using System.Collections.Generic;

namespace NUnitTesting
{
	public class RomanNumeralWithTDD
	{
		static Dictionary<char, int>
			Data = new Dictionary<char, int>()
		{
			{'I', 1 },
			{'V', 5 },
			{'X', 10 },
			{'L', 50 },
			{'C', 100 },
			{'D', 500 },
			{'M', 1000 }
		};
		public static int Parse(string roman)
		{
			int result = 0;
			for (int i = 0; i < roman.Length; i++)
			{
				if (roman.Length > i + 1 && isSubtractive(roman[i], roman[i + 1]))
				{
					result -= Data[roman[i]];
				}
				else
				{
					result += Data[roman[i]];
				}
			}
			return result;
		}

		private static bool isSubtractive(char v1, char v2)
		{
			return Data[v1] < Data[v2];
		}
	}
}