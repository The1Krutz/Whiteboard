namespace Questions
{
    public interface IDivision
    {
        /**
         * Write a function that accepts two ints a and b, and returns a/b. Must be implemented without using the division or modulo operators
         * ie: 7, 2 should return 3
         */
        int Division(int numerator, int denominator);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class DivisionTest : IQuestion
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
