namespace Questions
{
    public interface IRemoveParentheses
    {
        /**
         * Write a function that accepts a string, removes all characters between parentheses (but not the parentheses), then returns the modified string
         * ie: "one (two) three" should return "one () three"
         */
        string RemoveParentheses(string inString);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class RemoveParenthesesTest : IQuestion
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
