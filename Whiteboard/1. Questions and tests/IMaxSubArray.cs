namespace Questions
{
    public interface IMaxSubArray
    {
        /**
         * Given an array of numbers, find the contiguous sub-array with the largest value.
         * ie: given [-2,1,-3,4,-1,2,1,-5,4], the contiguous subarray [4, -1, 2, 1] has the largest sum = 6.
         */
        int MaxSubArray(int[] nums);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class MaxSubArrayTest : IQuestion
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
