namespace Questions
{
    public interface ICheckUniqueCharacters
    {
        /**
         * Write a function that accepts a string, and returns whether the characters are all unique
         * ie: "hello" will return false, and "plant" will return true
         */
        bool AreAllCharactersUnique(string input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class CheckUniqueCharactersTest : ICheckUniqueCharacters
    {
        public abstract bool AreAllCharactersUnique(string input);

        [Theory]
        [InlineData("abcd", true)]
        [InlineData("plant", true)]
        [InlineData("potato", false)]
        [InlineData("hello", false)]
        public void Test(string input, bool expected)
        {
            Assert.Equal(expected, AreAllCharactersUnique(input));
        }
    }
}
