namespace Sample
{
    using System.Collections.Generic;
    using Tests;

    public class Validate_Brackets_1 : ValidateBracketsTest
    {
        public override bool ValidateBrackets(string input)
        {
            var openers = "[{(<";
            var closers = "]})>";

            var nesting = new Stack<char>();

            foreach (var currentChar in input)
            {
                if (openers.Contains(currentChar))
                {
                    // add opening brackets to the stack for later
                    nesting.Push(currentChar);
                }
                else if (closers.Contains(currentChar))
                {
                    if (nesting.Count == 0)
                    {
                        return false;
                    }
                    var open = nesting.Pop();
                    if (open == '[' && currentChar != ']'
                        || open == '{' && currentChar != '}'
                        || open == '(' && currentChar != ')'
                        || open == '<' && currentChar != '>')
                    {
                        return false;
                    }
                }
            }

            return nesting.Count == 0;
        }
    }

    public class Validate_Brackets_2 : ValidateBracketsTest
    {
        public override bool ValidateBrackets(string input)
        {
            var openers = "[{(<";
            var closers = "]})>";

            var nesting = new Stack<char>();

            foreach (var currentChar in input)
            {
                if (openers.Contains(currentChar))
                {
                    // add opening brackets to the stack for later
                    nesting.Push(currentChar);
                }
                else if (closers.Contains(currentChar))
                {
                    if (nesting.Count == 0)
                    {
                        return false;
                    }
                    var open = nesting.Pop();
                    if (openers.IndexOf(open) != closers.IndexOf(currentChar))
                    {
                        return false;
                    }
                }
            }

            return nesting.Count == 0;
        }
    }
}
