namespace Questions
{
    public interface IIntToRomanNumeral
    {
        /**
         * Write a function that accepts an integer, and returns that integer in Roman numerals (as a string).
         * Assume the number will be 0 < n < 40
         * ie: 4 should return "IV"
         */
        string IntToRomanNumeral(int input);
    }
}

namespace Tests
{
    using Questions;
    using System;
    using Xunit;

    public abstract class IntToRomanNumeralTest : IIntToRomanNumeral
    {
        public abstract string IntToRomanNumeral(int input);

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(28, "XXVIII")]
        [InlineData(29, "XXIX")]
        [InlineData(30, "XXX")]
        [InlineData(39, "XXXIX")]
        public void Test(int input, string expected)
        {
            Assert.Equal(expected, IntToRomanNumeral(input), ignoreCase:true);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        public void InputOutOfBounds(int input)
        {
            Assert.Throws<ArgumentException>(() => IntToRomanNumeral(input));
        }
    }
}
