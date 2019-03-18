namespace Questions
{
    public interface IRotateMatrix
    {
        /**
         * Write a function that accepts two ints a and b, and returns a/b. Must be implemented without using the division or modulo operators
         * ie: 7, 2 should return 3
         */
        void RotateMatrix(int[][] input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class RotateMatrixTest : IRotateMatrix
    {
        public abstract void RotateMatrix(int[][] input);


        public static TheoryData<int[][], int[][]> Testdata1 =>
            new TheoryData<int[][], int[][]>
            {
                {new int[][] {new int[]{1, 2}, new int[]{ 3, 4} },
                new int[][] {new int[]{3, 1}, new int[]{ 4, 2} } }
            };


        [Theory]
        [MemberData(nameof(Testdata1))]
        public void Test_RotateMatrix(int[][] input, int[][] expected)
        {
            Assert.NotEqual(expected, input);

            RotateMatrix(input);

            Assert.Equal(expected, input);
        }
    }
}
