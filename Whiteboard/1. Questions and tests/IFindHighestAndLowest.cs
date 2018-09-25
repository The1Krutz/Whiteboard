namespace Questions
{
    public interface IFindHighestAndLowest
    {
        /**
         * Write a function that accepts an integer array, and returns an integer array containing only the smallest and largest numbers in the input array.
         * ie: [4,3,7,1] should return [1,7]
         */
        int[] FindHighestAndLowest(int[] input);
    }
}

namespace Tests
{
    using Questions;
    using System;
    using System.Linq;
    using Xunit;

    public abstract class FindHighestAndLowestTest : IFindHighestAndLowest
    {
        public abstract int[] FindHighestAndLowest(int[] input);

        [Theory]
        [InlineData(new[] { 2, 1, 3, 4, 5 }, new[] { 1, 5 })] // unique elements
        [InlineData(new[] { 1 }, new[] { 1, 1 })] // single element
        [InlineData(new[] { 2, 2, 2, 2, 2, 2, 2 }, new[] { 2, 2 })] // multiple elements, only one unique
        public void Test(int[] input, int[] expected)
        {
            var result = FindHighestAndLowest(input);

            Assert.NotNull(result);
            Assert.Equal(expected.Length, result.Length);

            Assert.True(expected.All(z => result.Contains(z)));
            Assert.True(result.All(z => expected.Contains(z)));
        }

        [Fact]
        public void EmptyArray()
        {
            var input = new int[] { };

            Assert.Throws<ArgumentOutOfRangeException>(() => FindHighestAndLowest(input));
        }
    }
}
