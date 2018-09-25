
namespace Sample
{
    using System.Collections.Generic;
    using Tests;

    namespace Sample
    {
        public class ValidateBrackets : ValidateBracketsTest
        {
            public override bool BracketsAreValid(string input)
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
    }

    namespace Sample2
    {
        public class ValidateBrackets : ValidateBracketsTest
        {
            public override bool BracketsAreValid(string input)
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
}