
namespace Bragg5
{
    using Tests;

    namespace Gabriel
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;

        public class Validate_Brackets_attempt2 : ValidateBracketsTest
        {
            public override bool ValidateBrackets(string input)
            {
                string fliteredInput = "";
                foreach (var ch in input)
                {
                    if (ch == '(' || ch == '<' || ch == '{' || ch == '[' || ch == ')' || ch == '>' || ch == '}' || ch == ']')
                        fliteredInput += ch;
                }
                Stack<char> myStack = new Stack<char>();
                bool keepLooping = true;
                bool isValid = false;
                do
                {
                    foreach (var ch in fliteredInput)
                    {
                        // adds the opening bracket to the Stack
                        if (ch == '(' || ch == '<' || ch == '{' || ch == '[')
                        {
                            myStack.Push(ch);
                        }
                        // compares the closing brackets with with the last opening bracket on Stack and pops it if they match
                        else if ((ch == ')' || ch == '>' || ch == '}' || ch == ']') && myStack.Count() != 0)
                        {
                            if (myStack.Peek() + 1 == ch || myStack.Peek() + 2 == ch)
                            {
                                myStack.Pop();
                            }
                            else
                            {
                                return isValid;
                            }
                        }
                        //checks for unmatched closing brackets
                        else if ((ch == ')' || ch == '>' || ch == '}' || ch == ']') && myStack.Count() == 0)
                        {
                            return false;
                        }
                        else
                        {
                            keepLooping = false;
                            throw new Exception("\nInvalid Entry!");
                        }
                    }
                    // Checks for unmatched opening brackets
                    if (myStack.Count() == 0)
                    {
                        isValid = true;
                    }
                    keepLooping = false;
                } while (keepLooping);
                return isValid;
            }
        }

        /**
         * making private to hide from the tests
         */
        class Validate_Brackets_attempt1 : ValidateBracketsTest
        {
            public override bool ValidateBrackets(string input)
            {
                Stack<char> myStack = new Stack<char>();
                int[] openValues = { 40, 60, 91, 123 };
                int[] closeValues = { 41, 62, 93, 125 };
                bool keepLooping = true;
                bool isValid = false;
                do
                {

                    foreach (var ch in input)
                    {
                        // adds the opening bracket to the Stack
                        if (openValues.Contains(ch))
                        {
                            myStack.Push(ch);
                        }
                        // compares the closing brackets with with the last opening bracket on Stack and pops it if they match
                        else if (closeValues.Contains(ch) && myStack.Count() != 0)
                        {
                            if (myStack.Peek() + 1 == ch || myStack.Peek() + 2 == ch)
                            {
                                myStack.Pop();
                            }
                            else
                            {
                                return isValid;
                            }
                        }
                        //checks for unmatched closing brackets
                        else if (closeValues.Contains(ch) && myStack.Count() == 0)
                        {
                            return false;
                        }
                        else
                        {
                            keepLooping = false;
                            throw new Exception("\nInvalid Entry!");
                        }
                    }
                    // Checks for unmatched opening brackets
                    if (myStack.Count() == 0)
                    {
                        isValid = true;
                    }
                    keepLooping = false;
                } while (keepLooping);
                return isValid;
            }
        }

    }
}
