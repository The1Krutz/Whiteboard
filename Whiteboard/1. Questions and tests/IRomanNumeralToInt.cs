namespace Questions
{
    public interface IRomanNumeralToInt
    {
        /**
         * Write a function that accepts a Roman numeral string, and returns the int value of that roman numeral.
         * Assume the string is correctly formatted, and the number will be 0 < n < 40
         * ie: "IV" should return 4
         */
        int RomanNumeralToInt(string inString);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class RomanNumeralToIntTest : IQuestion
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
