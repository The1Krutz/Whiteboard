namespace Questions
{
    public interface IValidAnagram
    {
        /**
         * Given two strings s and t, write a function to determine if t is an anagram of s.
         * ie: 'rat' and 'car' returns false, 'rat' and 'tar' returns true
         */
        bool ValidAnagram(string string1, string string2);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class ValidAnagramTest : IQuestion
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
