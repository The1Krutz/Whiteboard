namespace Questions
{
    public interface IRemoveParentheses
    {
        /**
         * Write a function that accepts a string, removes all characters between parentheses (but not the parentheses), then returns the modified string
         * ie: "one (two) three" should return "one () three"
         */
        string RemoveParentheses(string input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class RemoveParenthesesTest : IRemoveParentheses
    {
        public abstract string RemoveParentheses(string input);

        [Theory]
        [InlineData("one( two )three", "one()three")]
        [InlineData("one()three", "one()three")]
        [InlineData("(one two three)", "()")]
        public void Test(string input, string expected)
        {
            Assert.Equal(expected, RemoveParentheses(input));
        }
    }
}
