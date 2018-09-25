namespace Questions
{
    using System.Collections.Generic;

    public interface IArrayMissingNumber
    {
        /**
         * Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
         * Find all the elements of [1, n] inclusive that do not appear in this array.
         * ie: [4,3,2,7,8,2,3,1] should return [5,6]
         */
        IEnumerable<int> FindMissingNumbers(int[] input);
    }
}

namespace Tests
{
    using Questions;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public abstract class ArrayMissingNumberTest : IArrayMissingNumber
    {
        public abstract IEnumerable<int> FindMissingNumbers(int[] input);

        public static TheoryData<int[], List<int>> Data =>
            new TheoryData<int[], List<int>>
                {
                    { new int[] { 1, 2, 4, 5, 6, 8, 9 }, new List<int> { 3, 7 }}, // simple
                    { new int[] { -4, 2, 4, 5, 6, 8, 9 } , new List<int> { -3, -2, -1, 0, 1, 3, 7 }}, // includes negatives
                    { new int[] { 2, 9, 6, 4, -4, 5, 8 }, new List<int> { -3, -2, -1, 0, 1, 3, 7 }}, // includes negatives out of order
                };


        [Theory]
        [MemberData(nameof(Data))]
        public void Test(int[] initial, List<int> expected)
        {
            var result = FindMissingNumbers(initial).ToList();

            Assert.NotNull(result);
            Assert.Equal(expected.Count, result.Count);

            Assert.All(result, z => Assert.Contains(z, expected));
        }
    }
}
