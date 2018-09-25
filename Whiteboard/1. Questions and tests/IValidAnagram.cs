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

    public abstract class ValidAnagramTest : IValidAnagram
    {
        public abstract bool ValidAnagram(string string1, string string2);

        [Theory]
        // no spaces
        [InlineData("rat", "tar", true)]
        [InlineData("crate", "react", true)]
        [InlineData("star", "arts", true)]
        [InlineData("rot", "tar", false)]
        [InlineData("crate", "roast", false)]
        [InlineData("star", "amps", false)]
        // with spaces
        [InlineData("i am a potato", "a patio atom", true)]
        [InlineData("i am a potato", "iota map oat", true)]
        [InlineData("rearrangement", "arrange term en", true)]
        [InlineData("i am a potato", "a patio amop", false)]
        [InlineData("i am a potato", "ioma map oat", false)]
        [InlineData("rearrangement", "arrange temp en", false)]
        // mixed case
        [InlineData("rat", "TAR", true)]
        [InlineData("crAte", "reaCt", true)]
        public void Test(string input1, string input2, bool expected)
        {
            Assert.Equal(expected, ValidAnagram(input1, input2));
        }
    }
}
