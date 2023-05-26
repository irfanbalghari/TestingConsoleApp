namespace TestingConsoleApp
{
	internal class timeInWords
	{
		public static string TimeInWords(int h, int m)
		{
			if (h < 1 || h > 12 || m < 0 || m > 59)
			{
				return "Invalid time";
			}

			string[] hours = {
			 "one", "two", "three", "four", "five", "six",
			"seven", "eight", "nine", "ten", "eleven", "twelve"
		  };

			string[] minutes = {
			"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
			"eleven", "twelve", "thirteen", "fourteen", "quarter", "sixteen", "seventeen",
			"eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three",
			"twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight",
			"twenty nine", "half"
			};

			if (m == 0)
			{
				return $"{hours[h - 1]} o'clock";
			}
			else if (m >= 1 && m <= 29 && m != 15 && m != 30)
			{
				if (m == 1) return $"{minutes[m - 1]} minute past {hours[h - 1]}";
				return $"{minutes[m - 1]} minutes past {hours[h - 1]}";
			}
			else if (m == 30 || m == 15)
			{
				return $"{minutes[m - 1]} past {hours[h - 1]}";
			}
			else if (m == 45)
			{
				return $"{minutes[(60 - m) - 1]} to {hours[h]}";
			}
			else if (m > 30 && m < 60 && m != 45)
			{
				return $"{minutes[(60 - m) - 1]} minutes to {hours[h]}";
			}

			return string.Empty;
		}


	}
}
