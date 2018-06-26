using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace GeeksForGeeks.Test
{
    namespace Arrays
    {
        public class TestCases
        {
            public static IEnumerable<TestCaseData> Kadanes()
            {
                yield return new TestCaseData("1 2 3").Returns(6);
                yield return new TestCaseData("-1 -2 -3 -4").Returns(-1);
            }

            public static IEnumerable<TestCaseData> StockBuySell()
            {
                yield return new TestCaseData("100 180 260 310 40 535 695").Returns("(0 3) (4 6)");
            }

            public static IEnumerable<TestCaseData> MissingNumberInArray()
            {
                yield return new TestCaseData("1 2 3 5").Returns(4);
                yield return new TestCaseData("1 2 3 4 5 6 7 8 10").Returns(9);
            }
            
            public static IEnumerable<TestCaseData> SubArrayWithGivenSum()
            {
                yield return new TestCaseData("1 2 3 4 5 6 7 8 9 10", 15).Returns("1 5");
                yield return new TestCaseData("1 2 3 7 5", 12).Returns("2 4");
            }

            public static IEnumerable<TestCaseData> SortArrayOfZerosOnesTwos()
            {
                yield return new TestCaseData("0 2 1 2 0").Returns("0 0 1 2 2");
            }

            public static IEnumerable<TestCaseData> Equilibrium()
            {
                yield return new TestCaseData("1 1").Returns(-1);
                yield return new TestCaseData("1 2 3").Returns(-1);
                yield return new TestCaseData("1 2 1").Returns(2);
                yield return new TestCaseData("1").Returns(1);
                yield return new TestCaseData("1 3 5 2 2").Returns(3);
            }

            public static IEnumerable<TestCaseData> MaxSumIncreasingSubsequence()
            {
                yield return new TestCaseData("1 90 90 2 3 100 4 5").Returns(281);
                yield return new TestCaseData("1 101 2 3 100 4 5").Returns(106);
                yield return new TestCaseData("10 5 4 3").Returns(10);
            }

            public static IEnumerable<TestCaseData> Leaders()
            {
                yield return new TestCaseData("16 17 4 3 5 2").Returns("17 5 2");
                yield return new TestCaseData("1 2 3 4 0").Returns("4 0");
            }
            
            public static IEnumerable<TestCaseData> Platforms()
            {
                yield return new TestCaseData("900  940 950  1100 1500 1800\n910 1200 1120 1130 1900 2000").Returns(3);
            }
       
            public static IEnumerable<TestCaseData> LargestNumberFromArray()
            {
                yield return new TestCaseData("3 30 34 5 9").Returns("9534330");
            }

            public static IEnumerable<TestCaseData> RotateRight()
            {
                yield return new TestCaseData("1", 0).Returns("1");
                yield return new TestCaseData("1", 1).Returns("1");
                yield return new TestCaseData("1", 2).Returns("1");
                yield return new TestCaseData("1 2", 0).Returns("1 2");
                yield return new TestCaseData("1 2", 1).Returns("2 1");
                yield return new TestCaseData("1 2", 2).Returns("1 2");
                yield return new TestCaseData("1 2 3", 0).Returns("1 2 3");
                yield return new TestCaseData("1 2 3", 1).Returns("3 1 2");
                yield return new TestCaseData("1 2 3", 2).Returns("2 3 1");
                yield return new TestCaseData("1 2 3", 7).Returns("3 1 2");
            }
        }

        [TestFixture]
        public class RotateRightTests
        {
            [TestCaseSource(typeof(TestCases), "RotateRight")]
            public string Test(string sv, int n)
            {
                var vs = Helpers.StringToArray(sv);
                GeeksForGeeks.Arrays.RotateRight(vs, n);
                return Helpers.ArrayToString(vs);
            }
        }
        [TestFixture]
        public class LargestNumberFromArrayTests
        {
            [TestCaseSource(typeof(TestCases), "LargestNumberFromArray")]
            public string Test(string sv)
            {
                return GeeksForGeeks.Arrays.LargestNumberFromArray(Helpers.StringToArray(sv));
            }
        }
        [TestFixture]
        public class PlatformsTests
        {
            [TestCaseSource(typeof(TestCases), "Platforms")]
            public int Test(string sv)
            {
                var parts = sv.Split(new char[] {'\n'});

                return GeeksForGeeks.Arrays.Platforms(parts[0], parts[1]);
            }
        }
        [TestFixture]
        public class LeadersTests
        {
            [TestCaseSource(typeof(TestCases), "Leaders")]
            public string Test(string sv)
            {
                return GeeksForGeeks.Arrays.Leaders(Helpers.StringToArray(sv));
            }
        }
        [TestFixture]
        public class MaxSumIncreasingSubsequenceTests
        {
            [TestCaseSource(typeof(TestCases), "MaxSumIncreasingSubsequence")]
            public int Test(string sv)
            {
                return GeeksForGeeks.Arrays.MaxSumIncreasingSubsequence(Helpers.StringToArray(sv));
            }
        }
        [TestFixture]
        public class EquilibriumTests
        {
            [TestCaseSource(typeof(TestCases),"Equilibrium")]
            public int Test(string sv)
            {
                return GeeksForGeeks.Arrays.Equilibrium(Helpers.StringToArray(sv));
            }
        }
        
        [TestFixture]
        public class SortArrayOfZerosOnesTwos
        {
            [TestCaseSource(typeof(TestCases), "SortArrayOfZerosOnesTwos")]
            public string Test(string sv)
            {
                return GeeksForGeeks.Arrays.SortArrayOfZerosOnesTwos(Helpers.StringToArray(sv));
            }
        }

        [TestFixture]
        public class SubArrayWithGivenSum
        {
            [TestCaseSource(typeof(TestCases), "SubArrayWithGivenSum")]
            public string Test(string sv, int expected)
            {
                return GeeksForGeeks.Arrays.SubArrayWithGivenSum(Helpers.StringToArray(sv), expected);
            }
            
        }

        [TestFixture]
        public class MissingNumberInArray
        {
            [TestCaseSource(typeof(TestCases), "MissingNumberInArray")]
            public int Test(string sv)
            {
                return GeeksForGeeks.Arrays.MissingNumberInArray(Helpers.StringToArray(sv));
            }
        }

        [TestFixture]
        public class StockBuySell
        {
            [TestCaseSource(typeof(TestCases), "StockBuySell")]
            public string Test(string sv)
            {
                return GeeksForGeeks.Arrays.StockBuySell(Helpers.StringToArray(sv));
            }
        }
        
        [TestFixture]
        public class Kadanes
        {
            [TestCase("")]
            public void Empty(string sv)
            {
                Assert.Throws<System.Exception>(() => { GeeksForGeeks.Arrays.Kadanes(Helpers.StringToArray(sv)); });
            }
            
            [TestCaseSource(typeof(TestCases), "Kadanes")]
            public int Test(string sv)
            {
                var vs = Helpers.StringToArray(sv);
                return GeeksForGeeks.Arrays.Kadanes(vs);
            }
        }
    }
}