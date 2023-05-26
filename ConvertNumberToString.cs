using System.Collections.Generic;

public class ConvertNumberToString
{
	public static string ConvertBasic(int number)
	{
		string[] words = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six",
			"Seven", "Eight", "Nine", "Ten" };

		string text = "";
		while (number > 0)
		{
			text = words[number % 10] + text;
			number /= 10;
		}

		return text;
	}

	private static string[] units = {
		"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
		"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
	};

	private static string[] tens = {
		"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
	};

	private static string[] groups = {
		"", "thousand", "million", "billion", "trillion", "quadrillion" ,"quintillion", "sextillion",
		"septillion", "octillion", "nonillion", "decillion"
	};

	public static string ConvertNumberToText(int number)
	{
		if (number == 0)
			return units[0];

		var words = new List<string>();
		int groupIndex = 0;

		while (number > 0)
		{
			if (number % 1000 != 0)
			{
				string groupWords = ConvertGroupToText(number % 1000);
				words.Add(groupWords + " " + groups[groupIndex]);
			}

			number /= 1000;
			groupIndex++;
		}

		words.Reverse();
		return string.Join(" ", words);
	}

	private static string ConvertGroupToText(int number)
	{
		var groupWords = new List<string>();

		if (number >= 100)
		{
			groupWords.Add(units[number / 100]);
			groupWords.Add("hundred");
			number %= 100;
		}

		if (number >= 20)
		{
			groupWords.Add(tens[number / 10]);
			number %= 10;
		}

		if (number > 0)
		{
			groupWords.Add(units[number]);
		}

		return string.Join(" ", groupWords);
	}

}

//One decillion = 1×1033
//One undecillion = 1×1036
//One duodecillion = 1×1039
//One tredecillion = 1×1042
//One quattuordecillion = 1×1045
//One quindecillion = 1×1048
//One sexdecillion = 1×1051
//One septemdecillion = 1×1054
//One octodecillion = 1×1057
//One novemdecillion = 1×1060
//One vigintillion = 1×1063
//One unvigintillion (or vigintunillion) = 1×1066
//One duovigintillion(or vigintiduoillion) = 1×1069
//One trevigintillion(or vigintitrillion) = 1×1072
//One quattuorvigintillion(or vigintiquadrillion) = 1×1075
//One quinvigintillion(or vigintiquintrillion) = 1×1078
//One sexvigintillion(or vigintisextillion) = 1×1081
//One septvigintillion(or vigintiseptillion) = 1×1084
//One octovigintillion(or vigintoctillion) = 1×1087
//One nonvigintillion(or vigintinonillion) = 1×1090
//One trigintillion = 1×1093
//One untrigintillion = 1×1096
//One duotrigintillion = 1×1099
//Ten-duotrigintillion = googol = 1×10100
//.
//.
//Skewer’s number = 1×10130
//.
//.
//Centillion = 1×10303
//.
//.
//Googolplex = 1x(1010)100
//.
//.
//Skewes’ Number: ((1010)10)3