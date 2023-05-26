using System.Collections.Generic;

namespace TestingConsoleApp
{
	public class GradeRounding
	{
		static public List<int> gradingStudents(List<int> grades)
		{


			for (int i = 0; i < grades.Count; i++)
			{
				if (grades[i] % 5 != 0)
				{
					int result = findMultiple(grades[i]);
					if ((result - grades[i]) < 3 && grades[i] >= 38)
					{
						grades[i] = result;
					}
				}
			}
			return grades;
		}
		static int findMultiple(int i)
		{
			for (int j = 0; j < 4; j++)
			{
				i += 1;
				if (i % 5 == 0)
				{
					return i;
				}

			}
			return i;
		}
	}
}
