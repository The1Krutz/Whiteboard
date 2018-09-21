
namespace Sample
{
    using Questions;
    using System.Collections.Generic;
    using Tests;

    namespace Sample
    {
        public class CharacterCount : CharacterCountTest
        {
            public override Dictionary<char, int> GetCharacterCount(string inString)
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
    }
}