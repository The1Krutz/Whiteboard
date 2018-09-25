
//namespace WhiteBoardTests
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    /**
//     * Write a function that accepts a string and a character, removes any instances of that character, then returns the modified string
//     * ie: "potato", 't' should return "poao"
//     */
//    public partial class BaseTest
//    {
//        [TestMethod]
//        [TestCategory("Remove Character")]
//        public void RemoveCharacter_SeparatedLettersToRemove()
//        {
//            var letter = 't';
//            var input = "potato";
//            var expected = "poao";

//            var result = implementation.RemoveCharacter(input, letter);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Remove Character")]
//        public void RemoveCharacter_MultipleRemovableTogether()
//        {
//            var letter = 'm';
//            var input = "programming";
//            var expected = "prograing";

//            var result = implementation.RemoveCharacter(input, letter);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Remove Character")]
//        public void RemoveCharacter_NoRemovableLetters()
//        {
//            var letter = 'x';
//            var input = "potato";
//            var expected = "potato";

//            var result = implementation.RemoveCharacter(input, letter);

//            Assert.AreEqual(expected, result);
//        }

//        [TestMethod]
//        [TestCategory("Remove Character")]
//        public void RemoveCharacter_EmptyString()
//        {
//            var letter = 'm';
//            var input = "";
//            var expected = "";

//            var result = implementation.RemoveCharacter(input, letter);

//            Assert.AreEqual(expected, result);
//        }
//    }
//}
