using System;
using System.Linq;

namespace TestingConsoleApp.HighAlgos
{
    public class RepeatedString
    {
        public static long action(string s, long n)
        {
            long strlenth = s.Length;
            long aCount = 0;
            string[] chars = s.Split("");
            //string substring=""; 
            foreach (char a in s)
            {
                if (a == 'a')
                {
                    aCount++;
                }
            }
            double t = n / strlenth;
            long repitationsRequired = (long)Math.Floor(t);
            long remaining = n % strlenth;
            int remainingcount = 0;
            for (int i = 0; i < remaining; i++)
            {
                if (s[i] == 'a')
                {
                    remainingcount++;
                }
            }
            return (repitationsRequired * aCount) + remainingcount;


        }
        public static long action2(string s, long n)
        {
            long times = n / s.Length;
            long remainder = n % s.Length;

            char ocurrencesOf = 'a';

            long count = (times * GetOcurrences(s, ocurrencesOf, s.Length))
                + GetOcurrences(s, ocurrencesOf, remainder);

            return count;
        }

        private static long GetOcurrences(string s, char ocurrencesOf, long length)
        {
            return s.Take((int)length).Count(x => x == ocurrencesOf);
        }
    }
}
