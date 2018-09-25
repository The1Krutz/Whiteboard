namespace Sample
{
    using Tests;

    namespace Sample
    {
        using System;
        using System.Collections.Generic;

        public class Sum_Of_Squares : SumOfSquaresTest
        {
            public override IEnumerable<Tuple<int, int>> SumOfSquares(int input)
            {
                if (input < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                var returning = new List<Tuple<int, int>>();
                int maxAb = (int)(Math.Sqrt(input) + 1);

                for (int i = 0; i < maxAb; i++)
                {
                    for (int j = i; j < maxAb; j++)
                    {
                        if (i * i + j * j == input)
                        {
                            returning.Add(Tuple.Create(i, j));
                        }
                    }
                }

                return returning;
            }
        }
    }
}