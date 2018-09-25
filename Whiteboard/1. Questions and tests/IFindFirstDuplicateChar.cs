namespace Questions
{
    public interface IFindFirstDuplicateChar
    {
        /**
         * Write a function that accepts a single string, and returns the first duplicated character in the string.
         * ie: 'abcdc' should return 'c', and 'abcdbc' should return 'b'
         */
        string FindFirstDuplicateChar(string input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class FindFirstDuplicateCharTest : IFindFirstDuplicateChar
    {
        public abstract string FindFirstDuplicateChar(string input);

        [Theory]
        [InlineData("abcdMddeeeee", "d" )] // has duplicate
        [InlineData("abcdefghijkl", "")] // has no duplicate
        [InlineData("", "")] // empty string
        public void Test(string input, string expected)
        {
            Assert.Equal(expected, FindFirstDuplicateChar(input));
        }
    }
}
