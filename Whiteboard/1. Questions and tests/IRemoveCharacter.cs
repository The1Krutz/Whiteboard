namespace Questions
{
    public interface IRemoveCharacter
    {
        /**
         * Write a function that accepts a string and a character, removes any instances of that character, then returns the modified string
         * ie: "potato", 't' should return "poao"
         */
        string RemoveCharacter(string inString, char removeMe);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class RemoveCharacterTest : IQuestion
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
