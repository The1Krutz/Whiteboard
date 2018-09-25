namespace Questions
{
    public interface IMaxSubArray
    {
        /**
         * Given an array of numbers, find the contiguous sub-array with the largest value.
         * ie: given [-2,1,-3,4,-1,2,1,-5,4], the contiguous subarray [4, -1, 2, 1] has the largest sum = 6.
         */
        int MaxSubArray(int[] input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class MaxSubArrayTest : IMaxSubArray
    {
        public abstract int MaxSubArray(int[] input);

        [Theory]
        [InlineData(new[] { 1, 2 }, 3)] // simple
        [InlineData(new[] { 1, 2, -1 }, 3)] // ends with negative, sub-total does not cross zero
        [InlineData(new[] { 1, 2, -1, 2 }, 4)]// negative in middle, sub-total does not cross zero
        [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)] // has negatives, and sub-total crosses zero
        public void Test(int[] input, int expected)
        {
            Assert.Equal(expected, MaxSubArray(input));
        }
    }
}
