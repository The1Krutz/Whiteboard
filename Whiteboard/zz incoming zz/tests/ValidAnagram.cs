
//namespace WhiteBoardTests
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Given two strings s and t, write a function to determine if t is an anagram of s.
//     * ie: 'rat' and 'car' returns false, 'rat' and 'tra' returns true
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Valid Anagram")]
//        public void ValidAnagram_TrueNoSpaces()
//        {
//            Assert.IsTrue(implementation.ValidAnagram("rat", "tar"));
//            Assert.IsTrue(implementation.ValidAnagram("crate", "react"));
//            Assert.IsTrue(implementation.ValidAnagram("star", "arts"));
//        }

//        [TestMethod]
//        [TestCategory("Valid Anagram")]
//        public void ValidAnagram_TrueWithSpaces()
//        {
//            Assert.IsTrue(implementation.ValidAnagram("i am a potato", "a patio atom"));
//            Assert.IsTrue(implementation.ValidAnagram("i am a potato", "iota map oat"));
//            Assert.IsTrue(implementation.ValidAnagram("rearrangement", "arrange term en"));
//        }

//        [TestMethod]
//        [TestCategory("Valid Anagram")]
//        public void ValidAnagram_FalseNoSpaces()
//        {
//            Assert.IsFalse(implementation.ValidAnagram("rot", "tar"));
//            Assert.IsFalse(implementation.ValidAnagram("crate", "roast"));
//            Assert.IsFalse(implementation.ValidAnagram("star", "amps"));
//        }

//        [TestMethod]
//        [TestCategory("Valid Anagram")]
//        public void ValidAnagram_FalseWithSpaces()
//        {
//            Assert.IsFalse(implementation.ValidAnagram("i am a potato", "a patio amop"));
//            Assert.IsFalse(implementation.ValidAnagram("i am a potato", "ioma map oat"));
//            Assert.IsFalse(implementation.ValidAnagram("rearrangement", "arrange temp en"));
//        }

//        [TestMethod]
//        [TestCategory("Valid Anagram")]
//        public void ValidAnagram_CapitalizationNoSpaces()
//        {
//            Assert.IsTrue(implementation.ValidAnagram("rat", "TAR"));
//            Assert.IsTrue(implementation.ValidAnagram("crAte", "reaCt"));
//        }
//    }
//}
