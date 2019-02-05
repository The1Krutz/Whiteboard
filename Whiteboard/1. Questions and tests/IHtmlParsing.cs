using System.Collections.Generic;

namespace Questions
{
    /**
     * honestly I think this is too complicated for a whiteboard question.
     * setting aside the fact that it's actually a question I got during my interview...
     * the answer I gave (and that I think he was expecting) was a lot less "hard code" and a lot more "describe what you would do"
     */
    public interface IHtmlParsingPart
    {
        /**
         * Given a document composed of HTML tags and content, write a function to parse the document into an ordered list of tags, in the order they appear in the document.
         * This function should take a string input and return a Queue<HTMLTag>
         */
        Queue<HtmlTag> HtmlParsingPart1(string input);

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
    using System;
    using Xunit;
    using static Questions.HtmlTag;

    public abstract class HtmlParsingTest : IHtmlParsingPart
    {
        public abstract Queue<HtmlTag> HtmlParsingPart1(string input);
        public abstract bool HtmlParsingPart2(Queue<HtmlTag> inQueue);

        public static TheoryData<string, Queue<HtmlTag>> Part1Data
        {
            get
            {
                var ex1 = new Queue<HtmlTag>();
                ex1.Enqueue(new HtmlTag("div", TagType.Opening));
                ex1.Enqueue(new HtmlTag("table", TagType.Opening));
                ex1.Enqueue(new HtmlTag("table", TagType.Closing));
                ex1.Enqueue(new HtmlTag("br", TagType.SelfClosing));
                ex1.Enqueue(new HtmlTag("div", TagType.Closing));

                var ex2 = new Queue<HtmlTag>();
                ex2.Enqueue(new HtmlTag("div", TagType.Opening));
                ex2.Enqueue(new HtmlTag("table", TagType.Opening));
                ex2.Enqueue(new HtmlTag("table", TagType.Closing));
                ex2.Enqueue(new HtmlTag("br", TagType.SelfClosing));
                ex2.Enqueue(new HtmlTag("div", TagType.Closing));

                var ex3 = new Queue<HtmlTag>();
                ex3.Enqueue(new HtmlTag("div", TagType.Opening));
                ex3.Enqueue(new HtmlTag("table", TagType.Opening));
                ex3.Enqueue(new HtmlTag("table", TagType.Closing));
                ex3.Enqueue(new HtmlTag("br", TagType.SelfClosing));
                ex3.Enqueue(new HtmlTag("div", TagType.Closing));

                return new TheoryData<string, Queue<HtmlTag>>
                {
                    {"<div> <table> </table> <br /> </div>", ex1 },
                    {"<div>nothing<table>of</table>substantive<br/>value</div>", ex2 },
                    {"    <    div      >    nothing    <   table   >    of    </   table    >   sub sta nt ive    <  br      />     v alu  e     </      div   >        ", ex3 },
                };
            }
        }

        public static TheoryData<Queue<HtmlTag>, bool> Part2Data
        {
            get
            {
                var ex1 = new Queue<HtmlTag>();
                ex1.Enqueue(new HtmlTag("div", TagType.Opening));
                ex1.Enqueue(new HtmlTag("table", TagType.Opening));
                ex1.Enqueue(new HtmlTag("table", TagType.Closing));
                ex1.Enqueue(new HtmlTag("div", TagType.Closing));

                var ex2 = new Queue<HtmlTag>();
                ex2.Enqueue(new HtmlTag("div", TagType.Opening));
                ex2.Enqueue(new HtmlTag("table", TagType.Opening));
                ex2.Enqueue(new HtmlTag("div", TagType.Closing));
                ex2.Enqueue(new HtmlTag("table", TagType.Closing));

                var ex3 = new Queue<HtmlTag>();
                ex3.Enqueue(new HtmlTag("div", TagType.Opening));
                ex3.Enqueue(new HtmlTag("table", TagType.Opening));
                ex3.Enqueue(new HtmlTag("table", TagType.Closing));
                ex3.Enqueue(new HtmlTag("br", TagType.SelfClosing));
                ex3.Enqueue(new HtmlTag("div", TagType.Closing));

                return new TheoryData<Queue<HtmlTag>, bool>
                {
                    { ex1, true },
                    { ex2, false },
                    { ex3, true },
                };
            }
        }

        [Theory]
        [MemberData(nameof(Part1Data))]
        public void Part1_Test(string input, Queue<HtmlTag> expected)
        {
            var result = HtmlParsingPart1(input);

            Assert.NotNull(result);
            Assert.Equal(expected.Count, result.Count);

            while (expected.Count > 0 && result.Count > 0)
            {
                var nextExpected = expected.Dequeue();
                var nextActual = result.Dequeue();

                Assert.Equal(nextExpected.Name, nextActual.Name);
                Assert.Equal(nextExpected.Type, nextActual.Type);
            }
        }

        [Fact]
        public void Part1_MalformedTag()
        {
            var input = "<div <table> </table> <br/> </div>";

            Assert.Throws<ArgumentException>(() => HtmlParsingPart1(input));
        }

        [Theory]
        [MemberData(nameof(Part2Data))]
        public void Part2_Test(Queue<HtmlTag> input, bool expected)
        {
            Assert.Equal(expected, HtmlParsingPart2(input));
        }
    }
}
