
//namespace WhiteBoardTests
//{
//    using System;
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Write a function that accepts a Roman numeral string, and returns the int value of that roman numeral.
//     * Assume the string is correctly formatted, and the number will be 0 < n < 40
//     * ie: "IV" should return 4
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Roman Numeral to Int")]
//        public void RomanNumeralToInt_I()
//        {
//            Assert.AreEqual(1, implementation.RomanNumeralToInt("I"), $"conversion failed for {1}");
//            Assert.AreEqual(2, implementation.RomanNumeralToInt("II"), $"conversion failed for {2}");
//            Assert.AreEqual(3, implementation.RomanNumeralToInt("III"), $"conversion failed for {3}");
//        }

//        [TestMethod]
//        [TestCategory("Roman Numeral to Int")]
//        public void RomanNumeralToInt_IV()
//        {
//            Assert.AreEqual(1, implementation.RomanNumeralToInt("I"), $"conversion failed for {1}");

//            Assert.AreEqual(4, implementation.RomanNumeralToInt("IV"), $"conversion failed for {4}");
//            Assert.AreEqual(5, implementation.RomanNumeralToInt("V"), $"conversion failed for {5}");
//            Assert.AreEqual(6, implementation.RomanNumeralToInt("VI"), $"conversion failed for {6}");
//        }

//        [TestMethod]
//        [TestCategory("Roman Numeral to Int")]
//        public void RomanNumeralToInt_IVX()
//        {
//            Assert.AreEqual(9, implementation.RomanNumeralToInt("IX"), $"conversion failed for {9}");
//            Assert.AreEqual(10, implementation.RomanNumeralToInt("X"), $"conversion failed for {10}");
//            Assert.AreEqual(11, implementation.RomanNumeralToInt("XI"), $"conversion failed for {11}");

//            Assert.AreEqual(28, implementation.RomanNumeralToInt("XXVIII"), $"conversion failed for {28}");
//            Assert.AreEqual(29, implementation.RomanNumeralToInt("XXIX"), $"conversion failed for {29}");
//            Assert.AreEqual(30, implementation.RomanNumeralToInt("XXX"), $"conversion failed for {30}");

//            Assert.AreEqual(39, implementation.RomanNumeralToInt("XXXIX"), $"conversion failed for {39}");
//        }

//        [TestMethod]
//        [TestCategory("Roman Numeral to Int")]
//        public void RomanNumeralToInt_IVXLCMixedCases()
//        {
//            Assert.AreEqual(1, implementation.RomanNumeralToInt("i"), $"mixed case conversion failed for {1}");
//            Assert.AreEqual(2, implementation.RomanNumeralToInt("iI"), $"mixed case conversion failed for {2}");
//            Assert.AreEqual(3, implementation.RomanNumeralToInt("IiI"), $"mixed case conversion failed for {3}");

//            Assert.AreEqual(4, implementation.RomanNumeralToInt("Iv"), $"mixed case conversion failed for {4}");
//            Assert.AreEqual(5, implementation.RomanNumeralToInt("v"), $"mixed case conversion failed for {5}");
//            Assert.AreEqual(6, implementation.RomanNumeralToInt("vi"), $"mixed case conversion failed for {6}");

//            Assert.AreEqual(9, implementation.RomanNumeralToInt("Ix"), $"mixed case conversion failed for {9}");
//            Assert.AreEqual(10, implementation.RomanNumeralToInt("x"), $"mixed case conversion failed for {10}");
//            Assert.AreEqual(11, implementation.RomanNumeralToInt("xi"), $"mixed case conversion failed for {11}");

//            Assert.AreEqual(28, implementation.RomanNumeralToInt("XXvIiI"), $"mixed case conversion failed for {28}");
//            Assert.AreEqual(29, implementation.RomanNumeralToInt("XxIx"), $"mixed case conversion failed for {29}");
//            Assert.AreEqual(30, implementation.RomanNumeralToInt("xXx"), $"mixed case conversion failed for {30}");

//            Assert.AreEqual(39, implementation.RomanNumeralToInt("XXxiX"), $"mixed case conversion failed for {39}");
//        }

//        [TestMethod]
//        [TestCategory("Roman Numeral to Int")]
//        [ExpectedException(typeof(ArgumentException))]
//        public void RomanNumeralToInt_InvalidLetter()
//        {
//            implementation.RomanNumeralToInt("p");
//        }
//    }
//}
