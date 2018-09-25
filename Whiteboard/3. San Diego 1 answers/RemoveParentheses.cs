namespace SanDiego3
{
    using Tests;

    namespace Justin
    {
        /**
         * made class private to hide it from the tests
         */
        class Remove_Parentheses : RemoveParenthesesTest
        {
            public override string RemoveParentheses(string someString)
            {
                string newString = "";
                for (int i = 0; i < someString.Length; i++)
                {
                    newString += someString[i];
                    if (someString[i] == '(')
                    {
                        i++;
                        while (someString[i] != ')')
                        {
                            newString += "";
                            i++;
                            if (someString[i] == ')')
                            {
                                newString += someString[i];
                            }
                        }
                    }

                }
                return newString;
            }
        }
    }
}