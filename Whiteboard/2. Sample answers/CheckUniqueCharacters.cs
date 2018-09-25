namespace Sample
{
    using Tests;

    namespace Sample
    {
        public class Check_Unique_Characters : CheckUniqueCharactersTest
        {
            public override bool CheckUniqueCharacters(string input)
            {
                string buffer = "";

                foreach (char c in input)
                {
                    if (buffer.Contains(c))
                    {
                        return false;
                    }
                    else
                    {
                        buffer += c;
                    }
                }
                return true;
            }
        }
    }
}