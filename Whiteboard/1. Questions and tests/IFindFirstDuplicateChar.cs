namespace Questions
{
    public interface IFindFirstDuplicateChar
    {
        /**
         * Write a function that accepts a single string, and returns the first duplicated character in the string.
         * ie: 'abcdc' should return 'c', and 'abcdbc' should return 'b'
         */
        string FindFirstDuplicateChar(string inString);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class FindFirstDuplicateCharacterTest : IQuestion
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
