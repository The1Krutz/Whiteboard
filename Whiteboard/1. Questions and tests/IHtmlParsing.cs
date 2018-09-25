using System.Collections.Generic;

namespace Questions
{
    public interface IHtmlParsingPart
    {
        /**
         * Given a document composed of HTML tags and content, write a function to parse the document into an ordered list of tags, in the order they appear in the document.
         * This function should take a string input and return a Queue<HTMLTag>
         */
        Queue<HtmlTag> HtmlParsingPart1(string inString);

        /**
         * Given an ordered list of HTML tags, perform some logic to determine whether the tags are properly nested.
         * This function should take a Queue<HTMLTag> input and return a bool.
         */
        bool HtmlParsingPart2(Queue<HtmlTag> inQueue);
    }

    public class HtmlTag
    {
        public string Name { get; }
        public TagType Type { get; }

        public HtmlTag(string name, TagType type)
        {
            Name = name;
            Type = type;
        }

        public enum TagType
        {
            Opening,
            Closing,
            SelfClosing
        }
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class HtmlParsingTest : IQuestion
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
