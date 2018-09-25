namespace Questions
{
    public interface IValidateBrackets
    {
        /**
        * Given a string containing a combination of parentheses and brackets, determine if they open/close in the correct order.
        * []{}()<> are all valid.
        * ie: "{()}" should return true, but "{(})" should return false
        */
        bool BracketsAreValid(string input);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class ValidateBracketsTest : IValidateBrackets
    {
        public abstract bool BracketsAreValid(string inString);

        [Theory]
        /**
         * success cases
         */
        [InlineData("()", true)] // single brackets
        [InlineData("[]", true)] // single brackets
        [InlineData("{}", true)] // single brackets
        [InlineData("<>", true)] // single brackets
        [InlineData("([])", true)]  // two nested
        [InlineData("<([])>", true)] // three nested
        [InlineData("{}<>", true)] // two adjacent
        [InlineData("[]{}<>", true)] // three adjacent
        [InlineData("{()[]}", true)] // two nested and two adjacent
        [InlineData("[<>(<>()[])]", true)] // multiple nesting and adjacent
        [InlineData(" { } ", true)] // single brackets with spaces
        [InlineData(" ( [ { } ] )", true)] // three nested with spaces
        [InlineData(" { } < > ( )", true)] // three adjacent with spaces
        [InlineData("[ < > ( < > ( ) [ ] ) ]", true)] // multiple nesting and adjacent with spaces
        [InlineData("a[b]c", true)] // single bracket with letters
        [InlineData("i<j(k[l]m)n>o", true)] // three nested with letters
        [InlineData("u[v]w{x}y<z>a", true)] // three adjacent with letters
        [InlineData("a[b<c>d(e<f>g(h)i[j]k)l]m", true)] // multiple nesting and adjacent with letters
        /**
         * failure cases
         */
        [InlineData(")(", false)] // right number, wrong order
        [InlineData("[<(>)]", false)] // right number, wrong nesting
        [InlineData("{}<>()]", false)] // extra closing character
        [InlineData("([]{}<>", false)] // extra opening character
        public void Test(string initial, bool expected)
        {
            var result = BracketsAreValid(initial);

            Assert.Equal(expected, result);
        }
    }
}

