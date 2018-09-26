namespace Sample
{
    using Tests;

    namespace Sample
    {
        public class Find_First_Duplicate_Char : FindFirstDuplicateCharTest
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
    }

    namespace Sample2
    {
        using System.Collections.Generic;

        public class Find_First_Duplicate_Char : FindFirstDuplicateCharTest
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
    }

    namespace Sample3
    {
        public class Find_First_Duplicate_Char : FindFirstDuplicateCharTest
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
}