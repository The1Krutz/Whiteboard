
namespace Sample_Answers
{
    using Questions;
    using System.Collections.Generic;
    using Tests;

    public class Sample_CharacterCount : ICharacterCount
    {
        public Dictionary<char, int> CharacterCount(string inString)
        {
            var temp = new Dictionary<char, int>();

            foreach (var c in inString)
            {
                if (temp.ContainsKey(c))
                {
                    temp[c]++;
                }
                else
                {
                    temp.Add(c, 1);
                }
            }

            return temp;
        }
    }

    public class Sample_CharacterCountTests : CharacterCountTest
    {
        public Sample_CharacterCountTests()
        {
            implementation = new Sample_CharacterCount();
        }
    }
}