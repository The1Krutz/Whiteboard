
//namespace WhiteBoardTests
//{
//    using System;
//    using System.Linq;
//    using System.Collections.Generic;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Given a non-negative integer c, return a list of all possible combinations of numbers a and b such that a^2 + b^2 = c.
//     * ie: 5 returns <1,2> because 1^2 + 2^2 = 1 + 4 = 5
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Sum of Squares")]
//        public void SumOfSquares_SingleAnswer()
//        {
//            int input = 5;
//            var expected = new List<Tuple<int, int>>{
//                Tuple.Create(1,2)
//            };

//            var result = implementation.SumOfSquares(input).ToList();

//            Assert.IsNotNull(result);

//            Assert.IsTrue(expected.All(z => result.Contains(z)));
//            Assert.IsTrue(result.All(z => expected.Contains(z)));
//        }

//        [TestMethod]
//        [TestCategory("Sum of Squares")]
//        public void SumOfSquares_MultipleAnswers()
//        {
//            int input = 25;
//            var expected = new List<Tuple<int, int>>{
//                Tuple.Create(3,4), // 9 + 16 = 25
//                Tuple.Create(0,5)  // 0 + 25 = 25
//            };

//            var result = implementation.SumOfSquares(input).ToList();

//            Assert.IsNotNull(result);

//            Assert.IsTrue(expected.All(z => result.Contains(z)));
//            Assert.IsTrue(result.All(z => expected.Contains(z)));
//        }

//        [TestMethod]
//        [TestCategory("Sum of Squares")]
//        public void SumOfSquares_NoAnswer()
//        {
//            int input = 7;

//            var result = implementation.SumOfSquares(input).ToList();

//            Assert.IsNotNull(result);
//            Assert.AreEqual(0, result.Count);
//        }

//        [TestMethod]
//        [TestCategory("Sum of Squares")]
//        [ExpectedException(typeof(ArgumentOutOfRangeException))]
//        public void SumOfSquares_NegativeNumber()
//        {
//            int input = -5;
//            implementation.SumOfSquares(input);
//        }
//    }
//}
