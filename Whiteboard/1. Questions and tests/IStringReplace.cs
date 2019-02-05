namespace Questions
{
    using System.Collections.Generic;
    public interface IStringReplace
    {
        /**
         * Given a character array, replace any occurences of a replacethis with the characters in withThis without replacing the original array
         * This method returns void becuase the original array should be moified in place, not replaced
         * ie: (['a','!','c'], '!', "%21") should return nothing, but the original array should now be ['a','%','2','1','b']
         */
        void StringReplace(List<char> str, char replaceThis, string withThis);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;
    using System.Collections.Generic;

    public abstract class StringReplaceTest : IStringReplace
    {
        public abstract void StringReplace(List<char> str, char replaceThis, string withThis);

        public static TheoryData<List<char>, char, string, List<char>> TestData =>
            new TheoryData<List<char>, char, string, List<char>>()
            {
                // one replacement
                { new List<char>{'a','!','b'}, '!', "%21", new List<char>{ 'a', '%', '2', '1', 'b' } },
                // two replacements
                { new List<char>{'a','!','b', '!', 'c'}, '!', "%21", new List<char>{ 'a', '%', '2', '1', 'b', '%', '2', '1', 'c' } },
                // empty list
                { new List<char>{ }, '!', "%21", new List<char>{   } },
                // no replacements
                { new List<char>{'a','b'}, '!', "%21", new List<char>{ 'a', 'b' } },
                // only replacement
                { new List<char>{'!'}, '!', "%21", new List<char>{ '%', '2', '1' } },
                // longer replacement
                { new List<char>{'a','!','b'}, '!', "%21535%", new List<char>{ 'a', '%', '2', '1', '5', '3', '5', '%', 'b' } },
                // replacement contains replacement character
                { new List<char>{'a','!','b'}, '!', "%!1", new List<char>{ 'a', '%', '!', '1', 'b' } },
            };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(List<char> str, char replaceThis, string withThis, List<char> expected)
        {
            StringReplace(str, replaceThis, withThis);

            Assert.Equal(expected, str);
        }
    }
}
