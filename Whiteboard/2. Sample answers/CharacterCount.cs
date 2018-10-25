namespace Sample
{
    using System.Collections.Generic;
    using Tests;

    public class Character_Count : CharacterCountTest
    {
        public override Dictionary<char, int> CharacterCount(string input)
        {
            var temp = new Dictionary<char, int>();

            foreach (var c in input)
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
