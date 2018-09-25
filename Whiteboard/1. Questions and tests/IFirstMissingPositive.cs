namespace Questions
{
    public interface IFirstMissingPositive
    {
        /**
         * Given an unsorted integer array, find the first missing positive number.
         * ie: [3, 4, -1, 1] should return 2.
         */
        int FirstMissingPositive(int[] input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class FirstMissingPositiveTest : IFirstMissingPositive
    {
        public abstract int FirstMissingPositive(int[] input);

        [Theory]
        [InlineData(new[] { 1 }, 2)] // simple
        [InlineData(new[] { 1, 2, 4, 5 }, 3)] // gap in the middle
        [InlineData(new[] { -1, 2, 4 }, 1)] // includes negative numbers
        [InlineData(new[] { -1, -2 }, 1)] // all negative numbers
        public void Test(int[] input, int expected)
        {
            Assert.Equal(expected, FirstMissingPositive(input));
        }
    }
}
