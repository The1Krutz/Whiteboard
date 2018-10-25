namespace Sample
{
    using System.Collections.Generic;
    using Tests;

    public class Find_First_Duplicate_Char_1 : FindFirstDuplicateCharTest
    {
        public override string FindFirstDuplicateChar(string input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (input[j] == input[i])
                    {
                        return input[j].ToString();
                    }
                }
            }

            return "";
        }
    }

    public class Find_First_Duplicate_Char_2 : FindFirstDuplicateCharTest
    {
        public override string FindFirstDuplicateChar(string input)
        {
            var temp = new HashSet<char>();

            foreach (var t in input)
            {
                if (!temp.Add(t))
                {
                    return t.ToString();
                }
            }

            return "";
        }
    }

    public class Find_First_Duplicate_Char_3 : FindFirstDuplicateCharTest
    {
        public override string FindFirstDuplicateChar(string input)
        {
            var temp = "";

            foreach (var t in input)
            {
                if (temp.Contains(t))
                {
                    return t.ToString();
                }
                temp += t;
            }

            return "";
        }
    }
}
