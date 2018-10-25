namespace Sample
{
    using System.Collections.Generic;
    using System.Linq;
    using Tests;

    public class Array_Intersection_1 : ArrayIntersectionTest
    {
        public override IEnumerable<int> ArrayIntersection(int[] input1, int[] input2)
        {
            var temp = new List<int>();

            foreach (var i in input1)
            {
                foreach (var j in input2)
                {
                    if (i == j && !temp.Contains(i))
                    {
                        temp.Add(i);
                    }
                }
            }

            return temp;
        }
    }

    public class Array_Intersection_2 : ArrayIntersectionTest
    {
        public override IEnumerable<int> ArrayIntersection(int[] input1, int[] input2)
        {
            return input1.Intersect(input2).Distinct();
        }
    }
}