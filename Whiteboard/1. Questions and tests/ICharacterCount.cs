﻿namespace Questions
{
    using System.Collections.Generic;

    public interface ICharacterCount
    {
        /**
         * Write a function that accepts a string, counts all occurrences of each character in that string, then returns a dictionary containing those counts
         * Order of the dictionary does not matter
         * ie: "test" should return {'t':2, 'e':1, 's':1}
         */
        Dictionary<char, int> CharacterCount(string input);
    }
}

namespace Tests
{
    using Questions;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public abstract class CharacterCountTest : ICharacterCount
    {
        public abstract Dictionary<char, int> CharacterCount(string input);

        public static TheoryData<string, Dictionary<char, int>> Data =>
            new TheoryData<string, Dictionary<char, int>>
                {
                    {"test", new Dictionary<char, int> { {'t', 2 }, {'e', 1 }, {'s', 1 } } },
                    {"", new Dictionary<char, int> { } },
                    {"test TEST", new Dictionary<char, int> { {'t', 2 }, {'e', 1 }, {'s', 1 }, {' ', 1 }, {'T', 2 }, {'E', 1 }, {'S', 1 } } }
                };


        [Theory]
        [MemberData(nameof(Data))]
        public void Test(string input, Dictionary<char, int> expected)
        {
            var result = CharacterCount(input);

            Assert.NotNull(result);
            Assert.Equal(expected.Count, result.Count);

            Assert.True(expected.All(z => result[z.Key] == z.Value));
            Assert.True(result.All(z => expected[z.Key] == z.Value));
        }
    }
}

