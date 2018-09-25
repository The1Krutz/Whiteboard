
//namespace WhiteBoardTests
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Write a function that accepts a single string, and returns the first duplicated character in the string.
//     * ie: 'abcdc' should return 'c'
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Find First Duplicate Character")]
//        public void FindFirstDuplicate_CharStringWithDuplicate()
//        {
//            var initial = "abcdMddeeeee";
//            var expected = "d";

//            var result = implementation.FindFirstDuplicateChar(initial);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Find First Duplicate Character")]
//        public void FindFirstDuplicate_CharNoDuplicates()
//        {
//            var initial = "abcdefghijkl";
//            var expected = "";

//            var result = implementation.FindFirstDuplicateChar(initial);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Find First Duplicate Character")]
//        public void FindFirstDuplicate_CharEmptyString()
//        {
//            var initial = "";
//            var expected = "";

//            var result = implementation.FindFirstDuplicateChar(initial);

//            Assert.AreEqual(expected, result);
//        }
//    }
//}
