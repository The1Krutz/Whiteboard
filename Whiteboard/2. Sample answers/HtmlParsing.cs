namespace Sample
{
    using Questions;
    using System;
    using System.Collections.Generic;
    using Tests;
    using static Questions.HtmlTag;

    public class Html_Parsing : HtmlParsingTest
    {
        public override Queue<HtmlTag> HtmlParsingPart1(string input)
        {
            var tempQueue = new Queue<HtmlTag>();
            var recordTagName = false;
            var tempTagName = "";
            var tempType = TagType.SelfClosing;

            for (var i = 0; i < input.Length; i++)
            {
                var prevChar = i > 0 ? input[i - 1].ToString() : null;
                var c = input[i].ToString();
                var nextChar = i < input.Length - 1 ? input[i + 1].ToString() : null;

                if (c == ">")
                {
                    recordTagName = false;
                    if (prevChar == "/")
                    {
                        tempType = TagType.SelfClosing;
                        tempTagName = tempTagName.Replace("/", "");
                    }

                    tempQueue.Enqueue(new HtmlTag(tempTagName.Trim(), tempType));
                    tempTagName = "";
                    continue;
                }

                if (recordTagName)
                {
                    if (c == "<")
                    {
                        throw new ArgumentException("tried to open a tag from inside an existing tag!");
                    }
                    tempTagName += c;
                }

                if (c == "<")
                {
                    recordTagName = true;
                    if (nextChar == "/")
                    {
                        tempType = TagType.Closing;
                        i++;
                    }
                    else
                    {
                        tempType = TagType.Opening;
                    }
                }
            }

            return tempQueue;
        }

        public override bool HtmlParsingPart2(Queue<HtmlTag> inQueue)
        {
            var nesting = new Stack<HtmlTag>();

            while (inQueue.Count > 0)
            {
                var currentTag = inQueue.Dequeue();

                switch (currentTag.Type)
                {
                    case TagType.Opening: // add opening tags to the stack for later checking
                        nesting.Push(currentTag);
                        break;
                    case TagType.Closing: // check current tag against last tag on the stack
                        var lastTag = nesting.Pop();

                        if (lastTag.Type != TagType.Opening || lastTag.Name != currentTag.Name)
                        {
                            return false;
                        }
                        break;
                    case TagType.SelfClosing: // ignore self-closing tags, as they do not affect nesting validity
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            // if the code makes it here, then the queue is properly ordered
            return true;
        }
    }
}