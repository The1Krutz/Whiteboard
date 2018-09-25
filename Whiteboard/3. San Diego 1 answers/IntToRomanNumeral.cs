namespace SanDiego3
{
    using Tests;

    namespace Justin
    {
        using System;
        using System.Collections.Generic;

        /**
         * made class private to hide it from the tests
         */
        class Int_To_Roman_Numeral : IntToRomanNumeralTest
        {
            public override string IntToRomanNumeral(int input)
            {
                List<char> romanNum = new List<char>();
                string returnString;
                for (; input >= 9; input -= 10)
                {
                    if (input == 9)
                    {
                        romanNum.Add('I');
                        romanNum.Add('X');
                    }
                    else
                    {
                        romanNum.Add('X');
                    }
                }
                for (; input >= 4; input -= 5)
                {
                    if (input == 4)
                    {
                        romanNum.Add('I');
                        romanNum.Add('V');
                    }
                    else
                    {
                        romanNum.Add('V');
                    }
                }
                for (; input >= 1; input -= 1)
                {
                    romanNum.Add('I');
                }
                returnString = String.Join("", romanNum.ToArray());
                return returnString;
            }
        }
    }
}

