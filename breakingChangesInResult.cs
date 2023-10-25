using System.Collections.Generic;

namespace TestingConsoleApp
{
    public class breakingChangesInResult
    {
       // Given an array of Ana's basketball scores all season, determine the number of times she breaks her best and worst records.
        public static List<int> breakingRecords(List<int> scores)
        {
            int hi = scores[0];
            int low = scores[0];
            int hicount = 0, lowcount = 0;
            List<int> result = new List<int>();
            scores.ForEach(x =>
            {
                if (x > hi)
                {
                    hi = x;
                    hicount++;
                }
                if (x < low)
                {
                    low = x;
                    lowcount++;
                }

            });
            result.Add(hicount);
            result.Add(lowcount);
            return result;
        }
    }
}
