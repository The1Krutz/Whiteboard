namespace Questions
{
    public interface IIntToRomanNumeral
    {
        /**
         * Write a function that accepts an integer, and returns that integer in Roman numerals (as a string).
         * Assume the number will be 0 < n < 40
         * ie: 4 should return "IV"
         */
        string IntToRomanNumeral(int inInt);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class IntToRomanNumeralTest : IQuestion
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
