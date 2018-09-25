namespace Questions
{
    public interface IFirstMissingPositive
    {
        /**
         * Given an unsorted integer array, find the first missing positive number.
         * ie: [3, 4, -1, 1] should return 2.
         */
        int FirstMissingPositive(int[] inArr);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class FirstMissingPositiveTest : IQuestion
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
