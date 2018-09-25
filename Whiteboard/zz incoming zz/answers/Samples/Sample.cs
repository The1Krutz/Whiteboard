
//namespace WhiteBoard
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;

//    public class Sample : AnswerBase
//    {
//        public override IEnumerable<int> ArrayMissingNumber(int[] inArr)
//        {
//            var returning = new List<int>();
//            int minValue = inArr.Min();
//            int maxValue = inArr.Max();

//            for (int i = minValue; i < maxValue; i++)
//            {
//                if (!inArr.Contains(i))
//                {
//                    returning.Add(i);
//                }
//            }

//            return returning;
//        }

//        public override int Division(int numerator, int denominator)
//        {
//            if (numerator < 0 || denominator <= 0)
//            {
//                throw new ArgumentException();
//            }

//            int returning = 0;

//            while (numerator >= 0)
//            {
//                numerator -= denominator;
//                returning++;
//            }

//            return returning - 1;
//        }

//        public override string FindFirstDuplicateChar(string inString)
//        {
//            for (var i = 0; i < inString.Length; i++)
//            {
//                for (var j = 0; j < i; j++)
//                {
//                    if (inString[j] == inString[i])
//                    {
//                        return inString[j].ToString();
//                    }
//                }
//            }

//            return "";
//        }

//        public override int[] FindHighestAndLowest(int[] inArr)
//        {
//            if (inArr.Length == 0)
//            {
//                throw new ArgumentOutOfRangeException(nameof(inArr), "input array needs to have at least one value");
//            }

//            var minInt = inArr[0];
//            var maxInt = inArr[0];

//            foreach (var t in inArr)
//            {
//                if (t > maxInt)
//                {
//                    maxInt = t;
//                }

//                if (t < minInt)
//                {
//                    minInt = t;
//                }
//            }

//            return new[] { minInt, maxInt };
//        }

//        public override int FirstMissingPositive(int[] inArr)
//        {
//            var temp = 1;

//            while (true)
//            {
//                var flag = false;
//                foreach (var i in inArr)
//                {
//                    if (!flag && i == temp)
//                    {
//                        flag = true;
//                    }
//                }

//                if (!flag)
//                {
//                    return temp;
//                }

//                temp++;
//            }
//        }

//        public override Queue<HtmlTag> HtmlParsingPart1(string inString)
//        {
//            var tempQueue = new Queue<HtmlTag>();
//            var recordTagName = false;
//            var tempTagName = "";
//            var tempType = TagType.SelfClosing;

//            for (var i = 0; i < inString.Length; i++)
//            {
//                var prevChar = i > 0 ? inString[i - 1].ToString() : null;
//                var c = inString[i].ToString();
//                var nextChar = i < inString.Length - 1 ? inString[i + 1].ToString() : null;

//                if (c == ">")
//                {
//                    recordTagName = false;
//                    if (prevChar == "/")
//                    {
//                        tempType = TagType.SelfClosing;
//                        tempTagName = tempTagName.Replace("/", "");
//                    }

//                    tempQueue.Enqueue(new HtmlTag(tempTagName.Trim(), tempType));
//                    tempTagName = "";
//                    continue;
//                }

//                if (recordTagName)
//                {
//                    if (c == "<")
//                    {
//                        throw new ArgumentException("tried to open a tag from inside an existing tag!");
//                    }
//                    tempTagName += c;
//                }

//                if (c == "<")
//                {
//                    recordTagName = true;
//                    if (nextChar == "/")
//                    {
//                        tempType = TagType.Closing;
//                        i++;
//                    }
//                    else
//                    {
//                        tempType = TagType.Opening;
//                    }
//                }
//            }

//            return tempQueue;
//        }

//        public override bool HtmlParsingPart2(Queue<HtmlTag> inQueue)
//        {
//            var nesting = new Stack<HtmlTag>();

//            while (inQueue.Count > 0)
//            {
//                var currentTag = inQueue.Dequeue();

//                switch (currentTag.Type)
//                {
//                    case TagType.Opening: // add opening tags to the stack for later checking
//                        nesting.Push(currentTag);
//                        break;
//                    case TagType.Closing: // check current tag against last tag on the stack
//                        var lastTag = nesting.Pop();

//                        if (lastTag.Type != TagType.Opening || lastTag.Name != currentTag.Name)
//                        {
//                            return false;
//                        }
//                        break;
//                    case TagType.SelfClosing: // ignore self-closing tags, as they do not affect nesting validity
//                        break;
//                    default:
//                        throw new ArgumentOutOfRangeException();
//                }
//            }

//            // if the code makes it here, then the queue is properly ordered
//            return true;
//        }

//        public override string IntToRomanNumeral(int inInt)
//        {
//            if (inInt <= 0 || inInt >= 40)
//            {
//                throw new ArgumentException("argument below zero or too high");
//            }

//            var temp = "";

//            while (inInt > 0)
//            {
//                // more checks for larger numbers here
//                if (inInt >= 10)
//                {
//                    temp += "X";
//                    inInt -= 10;
//                }
//                else if (inInt == 9)
//                {
//                    temp += "IX";
//                    inInt -= 9;
//                }
//                else if (inInt >= 5)
//                {
//                    temp += "V";
//                    inInt -= 5;
//                }
//                else if (inInt == 4)
//                {
//                    temp += "IV";
//                    inInt -= 4;
//                }
//                else
//                {
//                    temp += "I";
//                    inInt -= 1;
//                }
//            }

//            return temp;
//        }

//        public override int MaxSubArray(int[] nums)
//        {
//            var maxSoFar = nums[0];
//            var maxEndingHere = nums[0];

//            for (var i = 1; i < nums.Length; i++)
//            {
//                maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
//                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
//            }

//            return maxSoFar;
//        }

//        public override string RemoveCharacter(string inString, char removeMe)
//        {
//            var temp = "";

//            foreach (var c in inString)
//            {
//                if (c != removeMe)
//                {
//                    temp += c;
//                }
//            }

//            return temp;
//        }

//        public override string RemoveParentheses(string inString)
//        {
//            var temp = "";
//            var addThisChar = true;

//            foreach (var c in inString)
//            {
//                if (c == ')')
//                {
//                    addThisChar = true;
//                }

//                if (addThisChar)
//                {
//                    temp += c;
//                }

//                if (c == '(')
//                {
//                    addThisChar = false;
//                }
//            }

//            return temp;
//        }

//        public override int RomanNumeralToInt(string inString)
//        {
//            var temp = 0;
//            inString = inString.ToUpperInvariant();

//            for (var i = 0; i < inString.Length; i++)
//            {
//                switch (inString[i])
//                {
//                    case 'X':
//                        temp += 10;
//                        break;
//                    case 'V':
//                        temp += 5;
//                        break;
//                    case 'I':
//                        if (i == inString.Length - 1)
//                        {
//                            temp += 1;
//                            break;
//                        }

//                        switch (inString[i + 1])
//                        {
//                            case 'X':
//                                temp += 9;
//                                i++;
//                                break;
//                            case 'V':
//                                temp += 4;
//                                i++;
//                                break;
//                            default:
//                                temp += 1;
//                                break;
//                        }
//                        break;
//                    default:
//                        throw new ArgumentException($"invalid character detected '{inString[i]}'");
//                }
//            }

//            return temp;
//        }

//        public override IEnumerable<Tuple<int, int>> SumOfSquares(int c)
//        {
//            if (c < 0)
//            {
//                throw new ArgumentOutOfRangeException();
//            }

//            var returning = new List<Tuple<int, int>>();
//            int maxAb = (int)(Math.Sqrt(c) + 1);

//            for (int i = 0; i < maxAb; i++)
//            {
//                for (int j = i; j < maxAb; j++)
//                {
//                    if (i * i + j * j == c)
//                    {
//                        returning.Add(Tuple.Create(i, j));
//                    }
//                }
//            }

//            return returning;
//        }

//        public override bool ValidAnagram(string string1, string string2)
//        {
//            bool returning = true;
//            string1 = string1.ToLowerInvariant();
//            string2 = string2.ToLowerInvariant();

//            List<char> alphabet = new List<char> {
//                 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
//             };

//            alphabet.ForEach(letter => returning = returning && string1.Count(z => z == letter) == string2.Count(z => z == letter));

//            return returning;
//        }
        
//        public bool AreAllCharactersUnique(string input)
//        {
//            string temp = "";
//            foreach (char i in input)
//            {
//                if (temp.IndexOf(i) != -1)
//                {
//                    return false;
//                }
//                temp += i;
//            }
//            return true;
//        }
//    }
//}
