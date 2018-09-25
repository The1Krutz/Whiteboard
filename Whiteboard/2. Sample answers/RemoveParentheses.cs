namespace Sample
{
    using Tests;

    namespace Sample
    {
        public class Remove_Parentheses : RemoveParenthesesTest
        {
            public override string RemoveParentheses(string input)
            {
                var temp = "";
                var addThisChar = true;

                foreach (var c in input)
                {
                    if (c == ')')
                    {
                        addThisChar = true;
                    }

                    if (addThisChar)
                    {
                        temp += c;
                    }

                    if (c == '(')
                    {
                        addThisChar = false;
                    }
                }

                return temp;
            }
        }
    }
}