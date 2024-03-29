﻿namespace Questions
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
    using System;
    using Questions;
    using Xunit;

    public abstract class DivisionTest : IDivision
    {
        public abstract int Division(int numerator, int denominator);

        [Theory]
        // positive, divide evenly
        [InlineData(4, 1, 4)]
        [InlineData(2, 2, 1)]
        [InlineData(9, 3, 3)]
        // positive, don't divide evenly
        [InlineData(7, 3, 2)]
        [InlineData(4, 3, 1)]
        [InlineData(5, 2, 2)]
        // one negative
        [InlineData(-4, 1, -4)]
        [InlineData(7, -3, -2)]
        // two negative
        [InlineData(-4, -1, 4)]
        [InlineData(-7, -3, 2)]
        public void Test(int numerator, int denominator, int expected)
        {
            Assert.Equal(expected, Division(numerator, denominator));
        }

        [Fact]
        public void Test_DivideByZero()
        {
            Assert.Throws<ArgumentException>(() => Division(2, 0));
        }
    }
}
