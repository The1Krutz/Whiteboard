
//namespace WhiteBoardTests
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Given an array of numbers, find the contiguous sub-array with the largest value, and return that value
//     * ie: given [-2, 1, -3, 4, -1, 2, 1, -5, 4], the contiguous subarray [4, -1, 2, 1] has the largest sum = 6.
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Max Sub Array")]
//        public void MaxSubArray_Simple()
//        {
//            var input = new[] { 1, 2 };
//            var expected = 3;

//            Assert.AreEqual(expected, implementation.MaxSubArray(input));
//        }

//        [TestMethod]
//        [TestCategory("Max Sub Array")]
//        public void MaxSubArray_EndsWithNegativeDoesNotCrossZero()
//        {
//            var input = new[] { 1, 2, -1 };
//            var expected = 3;

//            Assert.AreEqual(expected, implementation.MaxSubArray(input));
//        }


//        [TestMethod]
//        [TestCategory("Max Sub Array")]
//        public void MaxSubArray_HasNegativeDoesNotCrossZero()
//        {
//            var input = new[] { 1, 2, -1, 2 };
//            var expected = 4;

//            Assert.AreEqual(expected, implementation.MaxSubArray(input));
//        }

//        [TestMethod]
//        [TestCategory("Max Sub Array")]
//        public void MaxSubArray_HasNegativesAndCrossesZero()
//        {
//            var input = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
//            var expected = 6;

//            Assert.AreEqual(expected, implementation.MaxSubArray(input));
//        }
//    }
//}
