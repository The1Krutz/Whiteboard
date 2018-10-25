namespace Sample
{
    using System;
    using Tests;

    public class Int_To_Roman_Numeral : IntToRomanNumeralTest
    {
        public override string IntToRomanNumeral(int input)
        {
            if (input <= 0 || input >= 40)
            {
                throw new ArgumentException("argument below zero or too high");
            }

            var temp = "";

            while (input > 0)
            {
                // more checks for larger numbers here
                if (input >= 10)
                {
                    temp += "X";
                    input -= 10;
                }
                else if (input == 9)
                {
                    temp += "IX";
                    input -= 9;
                }
                else if (input >= 5)
                {
                    temp += "V";
                    input -= 5;
                }
                else if (input == 4)
                {
                    temp += "IV";
                    input -= 4;
                }
                else
                {
                    temp += "I";
                    input -= 1;
                }
            }

            return temp;
        }
    }
}
