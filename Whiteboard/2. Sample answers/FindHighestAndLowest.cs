namespace Sample
{
    using System;
    using Tests;

    public class Find_Highest_And_Lowest : FindHighestAndLowestTest
    {
        public override int[] FindHighestAndLowest(int[] input)
        {
            if (input.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(input), "input array needs to have at least one value");
            }

            var minInt = input[0];
            var maxInt = input[0];

            foreach (var t in input)
            {
                if (t > maxInt)
                {
                    maxInt = t;
                }

                if (t < minInt)
                {
                    minInt = t;
                }
            }

            return new[] { minInt, maxInt };
        }
    }
}
