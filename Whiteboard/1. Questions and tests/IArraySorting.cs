namespace Questions
{
    public interface IArraySort
    {
        /**
         * Write a function that accepts an array of integers, and returns a sorted array.
         * Obviously you can't just use the built in C# stuff to do this for you.
         * ie: [1,3,2] should return [1,2,3]
         */
        int[] ArraySort(int[] input);
    }
}

namespace Tests
{
    using Questions;
    using System.Linq;
    using Xunit;

    public abstract class ArraySortTest : IArraySort
    {
        public abstract int[] ArraySort(int[] input);

        public static TheoryData<int[], int[]> Data =>
            new TheoryData<int[], int[]>
                {
                    { new int[] { 3, 1, 2 }, new int[] { 1, 2, 3 }}, // simple
                    { new int[] { -4, 9, 2, 4, 8, 5, 6 } , new int[] { -4, 2, 4, 5, 6, 8, 9 }}, // includes negatives
                    { new int[] { 5, 2, 9, 4, 2 }, new int[] { 2, 2, 4, 5, 9 }}, // includes duplicates
                    { new int[] { 5, 2, -9, 4, 2 }, new int[] {-9, 2, 2, 4, 5  } } // includes negatives and duplicates
                };


        [Theory]
        [MemberData(nameof(Data))]
        public void Test(int[] input, int[] expected)
        {
            var result = ArraySort(input);

            Assert.NotNull(result);
            Assert.Equal(expected.Length, result.Length);

            Assert.True(expected.All(z => result.Contains(z)));
            Assert.True(result.All(z => expected.Contains(z)));
        }
    }
}
