namespace Bragg5
{
    using Tests;

    namespace Gabriel
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;

        public class Validate_Brackets_attempt3 : ValidateBracketsTest
        {
            public override bool ValidateBrackets(string input)
            {
                // if there are expressions in-between the parentheses we need to filter those expresisons out before attempting to validate the input string
                string fliteredInput = "";
                char[] arr = { '(', ')', '<', '>', '[', ']', '{', '}' };
                foreach (var ch in input)
                {
                    if (arr.Contains(ch))
                    {
                        fliteredInput += ch;
                    }
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

        /**
         * private to hide from tests (since it throws exceptions instead of returning "" like I expected when I wrote the tests)
         */
        class Find_First_Duplicate_Char : FindFirstDuplicateCharTest
        {
            public override string FindFirstDuplicateChar(string input)
            {
                int duplicateIndex = -1;
                char[] array = input.ToCharArray();
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            // stores the duplicate's index if 1) it's the first duplicate encounterred 2) if it appears in the string before the previously saved duplicate does.
                            if (duplicateIndex == -1 || j < duplicateIndex)
                            {
                                // stores the duplicated char's index
                                duplicateIndex = j;
                            }
                        }
                    }
                }
                // if duplicateIndex's value hasn't changed then no duplicates were encountered.
                if (duplicateIndex == -1)
                {
                    throw new Exception("No duplicate characters were found");
                }
                else
                {
                    return array[duplicateIndex].ToString(); // I added .tostring() -thomas
                }
            }
        }
    }
}
