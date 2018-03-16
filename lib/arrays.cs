using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace GeeksForGeeks
{
    public class Arrays
    {
        public static string Leaders(int[] vs)
        {
            var leaders = new Stack<int>();
            
            var max = vs[vs.Length - 1];

            leaders.Push(max);

            for (var i = vs.Length - 2; i >= 0; i--)
            {
                if (vs[i] > max)
                {
                    leaders.Push(vs[i]);
                    max = vs[i];
                }
            }

            var sb = new StringBuilder();
            while (leaders.Count > 0)
            {
                sb.AppendFormat("{0} ", leaders.Pop());
            }

            return sb.ToString().Trim();
        }
        
        public static int MaxSumIncreasingSubsequence(int[] vs)
        {
            if (vs.Length == 0)
            {
                throw new System.Exception("Invalid length!");
            }

            var ms = new int[vs.Length];

            for (var i = 0; i < ms.Length; i++)
            {
                ms[i] = 0;
            }

            ms[0] = vs[0];
            
            for (var i = 1; i < ms.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    ms[i] = vs[i] >= vs[j] && ms[j] + vs[i] > ms[i] ? ms[j] + vs[i] : ms[i];
                }
            }

            return ms.Max();

        }

        public static int Equilibrium(int[] vs)
        {
            if( vs.Length == 0 || vs.Length == 2 )
            {
                return -1;
                //throw new System.Exception("Invalid length!");
            }
            
            if( vs.Length == 1 )
            {
                return vs[0];
            }

            var lsum = vs[0];
            var rsum = vs.Skip(2).Sum();
            var done = lsum == rsum;
            var idx = 1; 
            
            for( ; idx < vs.Length-1 && !done; idx++ )
            {
                lsum += vs[idx];
                rsum -= vs[idx+1];

                done = lsum == rsum;
            }

            return lsum == rsum ? idx + 1 : -1;
        }
        
        public static string SortArrayOfZerosOnesTwos(int[] vs)
        {
            var zero = 0;
            var one = 0;
            var two = 0;

            foreach (var v in vs)
            {
                switch (v)
                {
                    case 0:
                        zero++;
                        break;
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                }
            }

            var sb = new StringBuilder();

            sb.Insert(0, "0 ", zero);
            sb.Insert(sb.Length, "1 ", one);
            sb.Insert(sb.Length, "2 ", two);

            return sb.ToString().Trim();
        }


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
