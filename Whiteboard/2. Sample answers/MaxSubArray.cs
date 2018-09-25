namespace Sample
{
    using Tests;

    namespace Sample
    {
        using System;

        public class Max_Sub_Array : MaxSubArrayTest
        {
            public override int MaxSubArray(int[] input)
            {
                var maxSoFar = input[0];
                var maxEndingHere = input[0];

                for (var i = 1; i < input.Length; i++)
                {
                    maxEndingHere = Math.Max(maxEndingHere + input[i], input[i]);
                    maxSoFar = Math.Max(maxSoFar, maxEndingHere);
                }

                return maxSoFar;
            }
        }
    }
}