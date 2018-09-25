
//namespace WhiteBoard
//{
//    using System;
//    using System.Collections.Generic;

//    public class Justin : AnswerBase
//    {
//        /**
//         * Testable public interface
//         * base method with expression bodied method that redirects to custom implementation
//         */

//        public override string RemoveCharacter(string inString, char removeMe) => RemoveChar(inString, removeMe);

//        public override string RemoveParentheses(string inString) => RemoveParenthesis(inString);

//        public override string IntToRomanNumeral(int inInt) => RomanNum(inInt);

//        /**
//         * Implementations pasted from student response
//         */
//        private string RemoveChar(string someString, char someLetter)
//        {
//            for (int i = 0; i < someString.Length; i++)
//            {
//                if (someString[i] == someLetter)
//                {
//                    someString = someString.Remove(i, 1);

//                    i--; // my addition based on conversation with justin -thomas
//                }
//            }
//            return someString;
//        }

//        // second attempt
//        public string RemoveParenthesis(string someString)
//        {

//            string newString = "";
//            for (int i = 0; i < someString.Length; i++)
//            {
//                newString += someString[i];
//                if (someString[i] == '(')
//                {
//                    i++;
//                    while (someString[i] != ')')
//                    {
//                        newString += "";
//                        i++;
//                        if (someString[i] == ')')
//                        {
//                            newString += someString[i];
//                        }
//                    }
//                }

//            }
//            return newString;
//        }
        
//        public string RomanNum(int x)
//        {
//            List<char> romanNum = new List<char>();
//            string returnString;
//            for (; x >= 9; x -= 10)
//            {
//                if (x == 9)
//                {
//                    romanNum.Add('I');
//                    romanNum.Add('X');
//                }
//                else
//                {
//                    romanNum.Add('X');
//                }
//            }
//            for (; x >= 4; x -= 5)
//            {
//                if (x == 4)
//                {
//                    romanNum.Add('I');
//                    romanNum.Add('V');
//                }
//                else
//                {
//                    romanNum.Add('V');
//                }
//            }
//            for (; x >= 1; x -= 1)
//            {
//                romanNum.Add('I');
//            }
//            returnString = String.Join("", romanNum.ToArray());
//            return returnString;
//        }

//    }
//}
