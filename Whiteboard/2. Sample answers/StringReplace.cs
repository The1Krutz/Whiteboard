namespace Sample
{
    using Tests;
    using System.Collections.Generic;

    public class StringReplace_1 : StringReplaceTest
    {
        public override void StringReplace(List<char> str, char replaceThis, string withThis)
        {
            char filler = '\0';
            int numReplace = 0;
            foreach (var c in str)
            {
                if (c == replaceThis)
                {
                    numReplace += withThis.Length - 1;
                }
            }

            int writepointer = str.Count + numReplace - 1;
            while (str.Count <= writepointer)
            {
                str.Add(filler);
            }

            for (int readpointer = str.Count - 1; readpointer >= 0; readpointer--)
            {
                if (str[readpointer] == replaceThis)
                {
                    for (int j = withThis.Length - 1; j >= 0; j--)
                    {
                        str[writepointer] = withThis[j];
                        writepointer--;
                    }
                }
                else if (str[readpointer] != filler)
                {
                    str[writepointer] = str[readpointer];
                    writepointer--;
                }
            }
        }
    }
}
