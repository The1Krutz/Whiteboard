
//namespace WhiteBoardTests
//{
//    using System;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Write a function that accepts an integer, and returns that integer in Roman numerals (as a string).
//     * Assume the number will be 0 < n < 40
//     * ie: 4 should return "IV"
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Int To Roman Numeral")]
//        public void IntToRomanNumeral_I()
//        {
//            Assert.AreEqual("I", implementation.IntToRomanNumeral(1).ToUpperInvariant(), $"conversion failed for {1}");
//            Assert.AreEqual("II", implementation.IntToRomanNumeral(2).ToUpperInvariant(), $"conversion failed for {2}");
//            Assert.AreEqual("III", implementation.IntToRomanNumeral(3).ToUpperInvariant(), $"conversion failed for {3}");
//        }

//        [TestMethod]
//        [TestCategory("Int To Roman Numeral")]
//        public void IntToRomanNumeral_IV()
//        {
//            Assert.AreEqual("I", implementation.IntToRomanNumeral(1).ToUpperInvariant(), $"conversion failed for {1}");

//            Assert.AreEqual("IV", implementation.IntToRomanNumeral(4).ToUpperInvariant(), $"conversion failed for {4}");
//            Assert.AreEqual("V", implementation.IntToRomanNumeral(5).ToUpperInvariant(), $"conversion failed for {5}");
//            Assert.AreEqual("VI", implementation.IntToRomanNumeral(6).ToUpperInvariant(), $"conversion failed for {6}");
//        }

//        [TestMethod]
//        [TestCategory("Int To Roman Numeral")]
//        public void IntToRomanNumeral_IVX()
//        {
//            Assert.AreEqual("IX", implementation.IntToRomanNumeral(9).ToUpperInvariant(), $"conversion failed for {9}");
//            Assert.AreEqual("X", implementation.IntToRomanNumeral(10).ToUpperInvariant(), $"conversion failed for {10}");
//            Assert.AreEqual("XI", implementation.IntToRomanNumeral(11).ToUpperInvariant(), $"conversion failed for {11}");

//            Assert.AreEqual("XXVIII", implementation.IntToRomanNumeral(28).ToUpperInvariant(), $"conversion failed for {28}");
//            Assert.AreEqual("XXIX", implementation.IntToRomanNumeral(29).ToUpperInvariant(), $"conversion failed for {29}");
//            Assert.AreEqual("XXX", implementation.IntToRomanNumeral(30).ToUpperInvariant(), $"conversion failed for {30}");

//            Assert.AreEqual("XXXIX", implementation.IntToRomanNumeral(39).ToUpperInvariant(), $"conversion failed for {39}");
//        }

//        [TestMethod]
//        [TestCategory("Int To Roman Numeral")]
//        [ExpectedException(typeof(ArgumentException))]
//        public void IntToRomanNumeral_ParamZero()
//        {
//            implementation.IntToRomanNumeral(0);
//        }

//        [TestMethod]
//        [TestCategory("Int To Roman Numeral")]
//        [ExpectedException(typeof(ArgumentException))]
//        public void IntToRomanNumeral_ParamTooHigh()
//        {
//            implementation.IntToRomanNumeral(101);
//        }
//    }
//}
