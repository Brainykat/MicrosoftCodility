using MicrosoftCodility;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(125,100)]
        [InlineData(10, 10)]
        [InlineData(1254, 1000)]
        [InlineData(12556, 10000)]
        public void Test1(int n, int u)
        {
            Class1 sln = new Class1();
            var res = sln.solution2(n);
            Assert.Equal(u, res);
        }
        [Theory]
        //[InlineData("011100", 7)]
        //[InlineData("1100",5)]
        //[InlineData("1000", 4)]
        [InlineData("0101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101",
            598)]
        public void Test2(string n, int u)
        {
            Class1 sln = new Class1();
            var res = sln.solution3(n);
            Assert.Equal(u, res);
        }

        [Theory]
        //                  0  1  2  3  4  5  6
        [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        //02 04 06 24 26 46 13
        [InlineData(new[] { 3, 5, 6, 3, 3, 5 }, 4)]

        public void solution_Returns_Expected(int[] array, int result)
        {
            Class1 sln = new Class1();
            var res = sln.solution4(array);
            Assert.Equal(result, res);
        }
    }
}
