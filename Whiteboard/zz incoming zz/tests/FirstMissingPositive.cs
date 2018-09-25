
//namespace WhiteBoardTests
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Given an unsorted integer array, find the first missing positive number.
//     * ie: [3, 4, -1, 1] should return 2.
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("First Missing Positive")]
//        public void FirstMissingPositive_Simple()
//        {
//            Assert.AreEqual(2, implementation.FirstMissingPositive(new[] { 1 }));
//        }

//        [TestMethod]
//        [TestCategory("First Missing Positive")]
//        public void FirstMissingPositive_Gap()
//        {
//            Assert.AreEqual(3, implementation.FirstMissingPositive(new[] { 1, 2, 4, 5 }));
//        }

//        [TestMethod]
//        [TestCategory("First Missing Positive")]
//        public void FirstMissingPositive_NegativeNumbers()
//        {
//            Assert.AreEqual(1, implementation.FirstMissingPositive(new[] { -1, 2, 4 }));
//        }

//        [TestMethod]
//        [TestCategory("First Missing Positive")]
//        public void FirstMissingPositive_AllNegativeNumbers()
//        {
//            Assert.AreEqual(1, implementation.FirstMissingPositive(new[] { -1, -2 }));
//        }
//    }
//}
