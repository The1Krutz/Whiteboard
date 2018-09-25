namespace Sample
{
    using Tests;

    namespace Sample
    {
        using System.Collections.Generic;

        public class Array_Intersection : ArrayIntersectionTest
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
    }

    namespace Sample2
    {
        using System.Collections.Generic;
        using System.Linq;

        public class Array_Intersection : ArrayIntersectionTest
        {
            public override IEnumerable<int> ArrayIntersection(int[] input1, int[] input2)
            {
                return input1.Intersect(input2).Distinct();
            }
        }
    }
}