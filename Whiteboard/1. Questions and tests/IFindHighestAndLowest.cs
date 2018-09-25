namespace Questions
{
    public interface IFindHighestAndLowest
    {
        /**
         * Write a function that accepts an integer array, and returns an integer array containing only the smallest and largest numbers in the input array.
         * ie: [4,3,7,1] should return [1,7]
         */
        int[] FindHighestAndLowest(int[] inArr);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class FindHighestAndLowestTest : IQuestion
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
