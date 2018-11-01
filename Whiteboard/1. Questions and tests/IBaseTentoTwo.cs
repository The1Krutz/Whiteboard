namespace Questions
{
    public interface IBaseTentoTwo
    {
        /**
         * Given two strings s and t, write a function to determine if t is an anagram of s.
         * ie: 'rat' and 'car' returns false, 'rat' and 'tar' returns true
         */
        string BaseTentoTwo(int input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class BaseTentoTwoTest : IBaseTentoTwo
    {
        public abstract string BaseTentoTwo(int input);

        [Theory]
        // zero
        [InlineData(0, "0")] // zero
        // powers of two
        [InlineData(1, "1")]
        [InlineData(4, "100")]
        [InlineData(8, "1000")]
        [InlineData(16, "10000")]
        [InlineData(32, "100000")]
        // other numbers
        [InlineData(7, "111")]
        [InlineData(3, "11")]
        [InlineData(5, "101")]
        [InlineData(19, "10011")]
        [InlineData(127, "1111111")]
        // larger numbers
        [InlineData(1000, "1111101000")]
        [InlineData(999999, "11110100001000111111")]
        [InlineData(999999999, "111011100110101100100111111111")]
        public void Test(int input, string expected)
        {
            Assert.Equal(expected, BaseTentoTwo(input));
        }
    }
}
