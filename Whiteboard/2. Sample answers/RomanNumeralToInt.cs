namespace Sample
{
    using System;
    using Tests;

    public class Roman_Numeral_To_Int : RomanNumeralToIntTest
    {
        public override int RomanNumeralToInt(string input)
        {
            var temp = 0;
            input = input.ToUpperInvariant();

            for (var i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'X':
                        temp += 10;
                        break;
                    case 'V':
                        temp += 5;
                        break;
                    case 'I':
                        if (i == input.Length - 1)
                        {
                            temp += 1;
                            break;
                        }

                        switch (input[i + 1])
                        {
                            case 'X':
                                temp += 9;
                                i++;
                                break;
                            case 'V':
                                temp += 4;
                                i++;
                                break;
                            default:
                                temp += 1;
                                break;
                        }
                        break;
                    default:
                        throw new ArgumentException($"invalid character detected '{input[i]}'");
                }
            }

            return temp;
        }
    }
}
