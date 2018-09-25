
//namespace WhiteBoardTests
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Write a function that accepts a string, removes all characters between parentheses (but not the parentheses), then returns the modified string
//     * ie: "one (two) three" should return "one () three"
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Remove Parentheses")]
//        public void RemoveParentheses_ParenthesesSeparateWithLettersBetween()
//        {
//            var initial = "one( two )three";
//            var expected = "one()three";

//            var result = implementation.RemoveParentheses(initial);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Remove Parentheses")]
//        public void RemoveParentheses_ParenthesesTouching()
//        {
//            var initial = "one()three";
//            var expected = "one()three";

//            var result = implementation.RemoveParentheses(initial);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Remove Parentheses")]
//        public void RemoveParentheses_ParenthesesCoverEverything()
//        {
//            var initial = "(one two three)";
//            var expected = "()";

//            var result = implementation.RemoveParentheses(initial);

//            Assert.AreEqual(expected, result);
//        }
//    }
//}
