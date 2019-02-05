namespace Sample
{
    using System;
    using System.Collections.Generic;
    using Tests;

    public class Sum_Of_Squares : SumOfSquaresTest
    {
        public override IEnumerable<(int a, int b)> SumOfSquares(int input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var returning = new List<(int a, int b)>();
            int maxAb = (int)(Math.Sqrt(input) + 1);

            for (int i = 0; i < maxAb; i++)
            {
                for (int j = i; j < maxAb; j++)
                {
                    if (i * i + j * j == input)
                    {
                        returning.Add((i, j));
                    }
                }
            }

            return returning;
        }
    }
}
