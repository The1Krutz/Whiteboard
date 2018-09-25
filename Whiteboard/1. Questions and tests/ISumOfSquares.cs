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
    using Xunit;

    public abstract class SumOfSquaresTest : IQuestion
    {
        public abstract bool signature(string input);

        [Theory]
        [InlineData("abcd", true)]
        [InlineData("plant", true)]
        [InlineData("potato", false)]
        [InlineData("hello", false)]
        public void Test(string input, bool expected)
        {
            Assert.Equal(expected, signature(input));
        }
    }
}
