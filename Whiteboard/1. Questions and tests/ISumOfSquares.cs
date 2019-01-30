using System;
using System.Collections.Generic;

namespace Questions
{
    public interface ISumOfSquares
    {
        /**
         * Given a non-negative integer c, return a list of all possible combinations of numbers a and b such that a^2 + b^2 = c.
         * ie: 5 returns <1,2> because 1^2 + 2^2 = 1 + 4 = 5
         */
        IEnumerable<(int a, int b)> SumOfSquares(int c);
    }
}

namespace Tests
{
    using Questions;
    using System.Linq;
    using Xunit;

    public abstract class SumOfSquaresTest : ISumOfSquares
    {
        public abstract IEnumerable<(int a, int b)> SumOfSquares(int c);

        public static TheoryData<int, IEnumerable<(int a, int b)>> Data =>
            new TheoryData<int, IEnumerable<(int a, int b)>>
                {
                    { 5, new List<(int a, int b)>{ (1,2) }},
                    { 25,new List<(int a, int b)>{
                        (3,4), // 9 + 16 = 25
                        (0,5)  // 0 + 25 = 25
                    } },
                    { 7, new List<(int a, int b)>{ }}
                };

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(int input, IEnumerable<(int a, int b)> expected)
        {
            var result = SumOfSquares(input).ToList();

            Assert.NotNull(result);
            Assert.Equal(expected.Count(), result.Count());

            Assert.True(expected.All(z => result.Contains(z)));
            Assert.True(result.All(z => expected.Contains(z)));
        }

        [Fact]
        public void NegativeNumber()
        {
            var input = -5;

            Assert.Throws<ArgumentOutOfRangeException>(() => SumOfSquares(input));
        }
    }
}
