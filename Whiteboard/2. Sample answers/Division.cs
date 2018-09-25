namespace Sample
{
    using Tests;

    namespace Sample
    {
        using System;

        public class Divison_ : DivisionTest
        {
            public override int Division(int numerator, int denominator)
            {
                if (numerator < 0 || denominator <= 0)
                {
                    throw new ArgumentException();
                }

                int returning = 0;

                while (numerator >= denominator)
                {
                    numerator -= denominator;
                    returning++;
                }

                return returning;
            }
        }
    }
}