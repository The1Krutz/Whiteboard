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
        IEnumerable<Tuple<int, int>> SumOfSquares(int c);
    }
}

namespace Tests
{
    using Questions;
    using System.Linq;
    using Xunit;

    public abstract class SumOfSquaresTest : ISumOfSquares
    {
        public abstract IEnumerable<Tuple<int, int>> SumOfSquares(int c);

        public static TheoryData<int, IEnumerable<Tuple<int, int>>> Data =>
            new TheoryData<int, IEnumerable<Tuple<int, int>>>
                {
                    { 5, new List<Tuple<int, int>>{ Tuple.Create(1,2) }},
                    { 25,new List<Tuple<int, int>>{
                        Tuple.Create(3,4), // 9 + 16 = 25
                        Tuple.Create(0,5)  // 0 + 25 = 25
                    } },
                    { 7, new List<Tuple<int, int>>{ }}
                };

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(int input, IEnumerable<Tuple<int, int>> expected)
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
