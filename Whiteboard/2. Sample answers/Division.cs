namespace Sample
{
    using System;
    using Tests;

    public class Divison_ : DivisionTest
    {
        public override int Division(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("cannot divide by zero");
            }

            int negativeCount = 0;

            if (numerator < 0)
            {
                numerator *= -1;
                negativeCount++;
            }

            if (denominator < 0)
            {
                denominator *= -1;
                negativeCount++;
            }

            int returning = 0;

            while (numerator >= denominator)
            {
                numerator -= denominator;
                returning++;
            }

            return returning * (negativeCount % 2 == 0 ? 1 : -1);
        }
    }
}
