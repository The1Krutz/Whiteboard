namespace Questions
{
    public interface IRomanNumeralToInt
    {
        /**
         * Write a function that accepts a Roman numeral string, and returns the int value of that roman numeral.
         * Assume the string is correctly formatted, and the number will be 0 < n < 40
         * ie: "IV" should return 4
         */
        int RomanNumeralToInt(string input);
    }
}

namespace Tests
{
    using Questions;
    using System;
    using Xunit;

    public abstract class RomanNumeralToIntTest : IRomanNumeralToInt
    {
        public abstract int RomanNumeralToInt(string input);

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XXVIII", 28)]
        [InlineData("XXIX", 29)]
        [InlineData("XXX", 30)]
        [InlineData("XXXIX", 39)]
        [InlineData("i", 1)]
        [InlineData("iI", 2)]
        [InlineData("IiI", 3)]
        [InlineData("Iv", 4)]
        [InlineData("v", 5)]
        [InlineData("vi", 6)]
        [InlineData("Ix", 9)]
        [InlineData("x", 10)]
        [InlineData("xi", 11)]
        [InlineData("XXvIiI", 28)]
        [InlineData("XxIx", 29)]
        [InlineData("xXx", 30)]
        [InlineData("XXxiX", 39)]
        public void Test(string input, int expected)
        {
            Assert.Equal(expected, RomanNumeralToInt(input));
        }

        [Theory]
        [InlineData("P")]
        public void InputOutOfBounds(string input)
        {
            Assert.Throws<ArgumentException>(() => RomanNumeralToInt(input));
        }
    }
}
