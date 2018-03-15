using System.Linq;

namespace GeeksForGeeks.Test
{
    public class Helpers
    {
        public static int[] StringToArray(string sv)
        {
            var tv = sv.Trim();

            if (tv.Length == 0)
            {
                return new int[] { };
            }

            return sv.Split(new char[] {' '}).Select(v => System.Convert.ToInt32(v)).ToArray();
        }
    }
}