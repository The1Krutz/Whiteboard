namespace Questions
{
    public interface IRemoveCharacter
    {
        /**
         * Write a function that accepts a string and a character, removes any instances of that character, then returns the modified string
         * ie: "potato", 't' should return "poao"
         */
        string RemoveCharacter(string input, char remove);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class RemoveCharacterTest : IRemoveCharacter
    {
        public abstract string RemoveCharacter(string input, char remove);

        [Theory]
        [InlineData("potato", 't', "poao")] // multiple separate
        [InlineData("programming", 'm', "prograing")] // multiple adjacent
        [InlineData("potato", 'x', "potato")] // string does not contain character
        [InlineData("",'m',"" )] // empty string
        public void Test(string input, char remove, string expected)
        {
            Assert.Equal(expected, RemoveCharacter(input, remove));
        }
    }
}
