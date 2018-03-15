using System;
using System.Globalization;
using System.Linq;

namespace GeeksForGeeks
{
    public class Arrays
    {
        public static string SubArrayWithGivenSum(int[] vs, int expected)
        {
            var i = 0;
            var j = 1;
            var sum = vs[0];
            var done = j >= vs.Length;

            while (!done)
            {
                while (sum < expected)
                {
                    sum += vs[j];
                    j++;
                }

                while (sum  > expected)
                {
                    sum -= vs[i];
                    i++;
                }

                done = sum == expected || i == j || j == vs.Length;
            }

            return sum == expected ? String.Format("{0} {1}", i+1, j) : "";
        }
        
       
        public static int MissingNumberInArray(int[] vs)
        {
            var actualSum = vs.Sum();

            var n = vs.Length;

            return (n + 1) * (n + 2) / 2 - actualSum;
        }

        public static int Kadanes(int[] vs)
        {
            if (vs.Length == 0)
            {
                throw new System.Exception("Array must be non-empty");
            }
            
            var max = vs[0];
            var cmax = vs[0];

            for (var i = 1; i < vs.Length; i++)
            {
                cmax = System.Math.Max(vs[i], cmax + vs[i]);
                max = System.Math.Max(max, cmax);
            }

            return max;
        }

        public static string StockBuySell(int[] vs)
        {
            var i = 0;
            var j = 0;

            var done = j >= vs.Length-1;

            var sb = new System.Text.StringBuilder();
            
            while (!done)
            {
                if (vs[j+1] > vs[j] )
                {
                    j++;
                }
                else
                {
                    if (i != j)
                    {
                        sb.Append(String.Format("({0} {1}) ", i, j));
                    }

                    j++;
                    i = j;
                }

                done = j == vs.Length - 1;
            }

            if (i != j)
            {
                sb.Append(String.Format("({0} {1})", i, j));
            }
            return sb.ToString().Trim();
        }
    }
}
