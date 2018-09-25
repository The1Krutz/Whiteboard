
//namespace WhiteBoardTests
//{
//    using System;
//    using System.Linq;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Write a function that accepts an integer array, and returns an integer array containing only the smallest and largest numbers in the input array.
//     * ie: [4,3,7,1] should return [1,7]
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Find Highest and Lowest")]
//        public void FindHighestAndLowest_ManyUniqueElements()
//        {
//            var initial = new[] { 2, 1, 3, 4, 5 };
//            var expected = new[] { 1, 5 };

//            var result = implementation.FindHighestAndLowest(initial);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Length, result.Length);

//            Assert.IsTrue(expected.All(z => result.Contains(z)));
//            Assert.IsTrue(result.All(z => expected.Contains(z)));
//        }

//        [TestMethod]
//        [TestCategory("Find Highest and Lowest")]
//        public void FindHighestAndLowest_OnlyOneElement()
//        {
//            var initial = new[] { 1 };
//            var expected = new[] { 1, 1 };

//            var result = implementation.FindHighestAndLowest(initial);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Length, result.Length);

//            Assert.IsTrue(expected.All(z => result.Contains(z)));
//            Assert.IsTrue(result.All(z => expected.Contains(z)));
//        }

//        [TestMethod]
//        [TestCategory("Find Highest and Lowest")]
//        public void FindHighestAndLowest_OnlyOneUniqueElement()
//        {
//            var initial = new[] { 2, 2, 2, 2, 2, 2, 2 };
//            var expected = new[] { 2, 2 };

//            var result = implementation.FindHighestAndLowest(initial);

//            Assert.IsNotNull(result);
//            Assert.AreEqual(expected.Length, result.Length);

//            Assert.IsTrue(expected.All(z => result.Contains(z)));
//            Assert.IsTrue(result.All(z => expected.Contains(z)));
//        }

//        [TestMethod]
//        [TestCategory("Find Highest and Lowest")]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void FindHighestAndLowest_EmptyArray()
//        {
//            var initial = new int[] { };
//            implementation.FindHighestAndLowest(initial);
//        }
//    }
//}
