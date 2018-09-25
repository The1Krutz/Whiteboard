
//namespace WhiteBoardTests
//{
//    using System;
//    using System.Collections.Generic;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;
//    using WhiteBoard;

//    /**
//     * Html Parsing Problem, Part 1.
//     * Given a document composed of HTML tags and content, write a function to parse the document into an ordered list of tags, in the order they appear in the document.
//     * This function should take a string input and return a Queue<HTMLTag>
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Html Parsing Pt 1")]
//        public void HtmlParsingPart1_Simple()
//        {
//            var htmlString = "<div> <table> </table> <br /> </div>";
//            var expected = new Queue<HtmlTag>();

//            expected.Enqueue(new HtmlTag("div", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Closing));
//            expected.Enqueue(new HtmlTag("br", TagType.SelfClosing));
//            expected.Enqueue(new HtmlTag("div", TagType.Closing));

//            var result = implementation.HtmlParsingPart1(htmlString);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Count, result.Count);

//            while (expected.Count > 0 && result.Count > 0)
//            {
//                var nextExpected = expected.Dequeue();
//                var nextActual = result.Dequeue();

//                Assert.AreEqual(nextExpected.Name, nextActual.Name);
//                Assert.AreEqual(nextExpected.Type, nextActual.Type);
//            }
//        }

//        [TestMethod]
//        [TestCategory("Html Parsing Pt 1")]
//        public void HtmlParsingPart1_FillerText()
//        {
//            var htmlString = "<div> nothing <table> of </table> substantive <br /> value </div>";
//            var expected = new Queue<HtmlTag>();

//            expected.Enqueue(new HtmlTag("div", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Closing));
//            expected.Enqueue(new HtmlTag("br", TagType.SelfClosing));
//            expected.Enqueue(new HtmlTag("div", TagType.Closing));

//            var result = implementation.HtmlParsingPart1(htmlString);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Count, result.Count);

//            while (expected.Count > 0 && result.Count > 0)
//            {
//                var nextExpected = expected.Dequeue();
//                var nextActual = result.Dequeue();

//                Assert.AreEqual(nextExpected.Name, nextActual.Name);
//                Assert.AreEqual(nextExpected.Type, nextActual.Type);
//            }
//        }

//        [TestMethod]
//        [TestCategory("Html Parsing Pt 1")]
//        public void HtmlParsingPart1_NoSpaces()
//        {
//            var htmlString = "<div>nothing<table>of</table>substantive<br/>value</div>";
//            var expected = new Queue<HtmlTag>();

//            expected.Enqueue(new HtmlTag("div", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Closing));
//            expected.Enqueue(new HtmlTag("br", TagType.SelfClosing));
//            expected.Enqueue(new HtmlTag("div", TagType.Closing));

//            var result = implementation.HtmlParsingPart1(htmlString);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Count, result.Count);

//            while (expected.Count > 0 && result.Count > 0)
//            {
//                var nextExpected = expected.Dequeue();
//                var nextActual = result.Dequeue();

//                Assert.AreEqual(nextExpected.Name, nextActual.Name);
//                Assert.AreEqual(nextExpected.Type, nextActual.Type);
//            }
//        }

//        [TestMethod]
//        [TestCategory("Html Parsing Pt 1")]
//        public void HtmlParsingPart1_TooMuchSpace()
//        {
//            var htmlString = "    <    div      >    nothing    <   table   >    of    </   table    >   sub sta nt ive    <  br      />     v alu  e     </      div   >        ";
//            var expected = new Queue<HtmlTag>();

//            expected.Enqueue(new HtmlTag("div", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Opening));
//            expected.Enqueue(new HtmlTag("table", TagType.Closing));
//            expected.Enqueue(new HtmlTag("br", TagType.SelfClosing));
//            expected.Enqueue(new HtmlTag("div", TagType.Closing));

//            var result = implementation.HtmlParsingPart1(htmlString);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Count, result.Count);

//            while (expected.Count > 0 && result.Count > 0)
//            {
//                var nextExpected = expected.Dequeue();
//                var nextActual = result.Dequeue();

//                Assert.AreEqual(nextExpected.Name, nextActual.Name);
//                Assert.AreEqual(nextExpected.Type, nextActual.Type);
//            }
//        }

//        [TestMethod]
//        [TestCategory("Html Parsing Pt 1")]
//        [ExpectedException(typeof(ArgumentException))]
//        public void HtmlParsingPart1_MalformedTag()
//        {
//            var htmlString = "<div <table> </table> <br/> </div>";

//            implementation.HtmlParsingPart1(htmlString);
//        }
//    }
//}
