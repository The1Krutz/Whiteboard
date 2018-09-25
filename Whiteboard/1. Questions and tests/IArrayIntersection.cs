namespace Questions
{
    using System.Collections.Generic;

    public interface IArrayIntersection
    {
        /**
         * Write a function that accepts two int arrays, and returns a single int list/array containing only numbers that are present in both arrays (an intersection of the two arrays)
         * ie: [1,2,3], [2,3,4] should return [2,3]
         */
        IEnumerable<int> CalculateArrayIntersection(int[] inArr1, int[] inArr2);
    }
}

namespace Tests
{
    using Questions;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public abstract class ArrayIntersectionTest : IArrayIntersection
    {
        public abstract IEnumerable<int> CalculateArrayIntersection(int[] inArr1, int[] inArr2);

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 2, 3, 4 }, new[] { 2, 3 })] // some common elements
        [InlineData(new[] { 1, 2, 2, 2, 2, 2, 2, 2, 3 }, new[] { 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4 }, new[] { 2, 3 })] // common elements with duplicates
        [InlineData(new[] { 1, 2, 3 }, new int[] { }, new int[] { })] // one empty param
        [InlineData(new int[] { }, new int[] { }, new int[] { })] // two empty params
        [InlineData(new[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { })] // no empty, no common elements
        public void Test(int[] initial1, int[] initial2, int[] expected)
        {
            var result = CalculateArrayIntersection(initial1, initial2).ToList();

            Assert.NotNull(result);
            Assert.Equal(expected.Count(), result.Count);

            Assert.True(expected.All(z => result.Contains(z)));
            Assert.True(result.All(z => expected.Contains(z)));
        }
    }
}
