namespace Sample
{
    using System.Collections.Generic;
    using System.Linq;
    using Tests;

    public class Array_Missing_Number_1 : ArrayMissingNumberTest
    {
        public override IEnumerable<int> ArrayMissingNumber(int[] input)
        {
            var returning = new List<int>();
            int minValue = input.Min();
            int maxValue = input.Max();

            for (int i = minValue; i < maxValue; i++)
            {
                if (!input.Contains(i))
                {
                    returning.Add(i);
                }
            }

            return returning;
        }
    }

    public class Array_Missing_Number_2 : ArrayMissingNumberTest
    {
        public override IEnumerable<int> ArrayMissingNumber(int[] input)
        {
            return Enumerable
             .Range(input.Min(), input.Max() - input.Min())
             .Where(z => !input.Contains(z));
        }
    }
}