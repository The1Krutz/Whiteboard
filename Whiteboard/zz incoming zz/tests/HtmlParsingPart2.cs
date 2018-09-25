
//namespace WhiteBoardTests
//{
//    using System.Collections.Generic;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;
//    using WhiteBoard;

//    /**
//     * Html Parsing Problem, Part 2.
//     * Given an ordered list of HTML tags, perform some logic to determine whether the tags are properly nested.
//     * This function should take a Queue<HTMLTag> input and return a bool.
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Html Parsing Pt 2")]
//        public void HtmlParsingPart2_InOrder()
//        {
//            var inputQueue = new Queue<HtmlTag>();

//            inputQueue.Enqueue(new HtmlTag("div", TagType.Opening));
//            inputQueue.Enqueue(new HtmlTag("table", TagType.Opening));
//            inputQueue.Enqueue(new HtmlTag("table", TagType.Closing));
//            inputQueue.Enqueue(new HtmlTag("div", TagType.Closing));

//            var result = implementation.HtmlParsingPart2(inputQueue);

//            Assert.IsTrue(result);
//        }

//        [TestMethod]
//        [TestCategory("Html Parsing Pt 2")]
//        public void HtmlParsingPart2_OutOfOrder()
//        {
//            var inputQueue = new Queue<HtmlTag>();

//            inputQueue.Enqueue(new HtmlTag("div", TagType.Opening));
//            inputQueue.Enqueue(new HtmlTag("table", TagType.Opening));
//            inputQueue.Enqueue(new HtmlTag("div", TagType.Closing));
//            inputQueue.Enqueue(new HtmlTag("table", TagType.Closing));

//            var result = implementation.HtmlParsingPart2(inputQueue);

//            Assert.IsFalse(result);
//        }

//        [TestMethod]
//        [TestCategory("Html Parsing Pt 2")]
//        public void HtmlParsingPart2_InOrderWithSelfClosing()
//        {
//            var inputQueue = new Queue<HtmlTag>();

//            inputQueue.Enqueue(new HtmlTag("div", TagType.Opening));
//            inputQueue.Enqueue(new HtmlTag("table", TagType.Opening));
//            inputQueue.Enqueue(new HtmlTag("table", TagType.Closing));
//            inputQueue.Enqueue(new HtmlTag("br", TagType.SelfClosing));
//            inputQueue.Enqueue(new HtmlTag("div", TagType.Closing));

//            var result = implementation.HtmlParsingPart2(inputQueue);

//            Assert.IsTrue(result);
//        }
//    }
//}
