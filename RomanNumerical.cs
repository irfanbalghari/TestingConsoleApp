using System.Collections.Generic;

namespace TestingConsoleApp
{
	public class RomanNumerical
	{
		static Dictionary<char, int> map = new Dictionary<char, int>()
		{
			{'I', 1 },
			{'V', 5 },
			{'X', 10 },
			{'L', 50 },
			{'C', 100 },
			{'D', 500 },
			{'M', 1000 }
		};
		public static int Parse(string romanStr)
		{
			//{ 'IV', 4 },
			//{ 'V', 5 },
			//{ 'VI', 6 }

			int result = 0;
			for (int i = 0; i < romanStr.Length; i++)
			{
				if (i + 1 < romanStr.Length && isSubtractive(romanStr[i], romanStr[i + 1]))
				{
					result -= map[romanStr[i]];
				}
				else
				{
					result += map[romanStr[i]];
				}
			}

			return result;
		}

		private static bool isSubtractive(char v1, char v2)
		{
			return map[v1] < map[v2];
		}
	}
}
