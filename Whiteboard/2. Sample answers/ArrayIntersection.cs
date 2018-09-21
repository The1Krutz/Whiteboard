
namespace Sample
{
    using Questions;
    using Tests;
    using System.Collections.Generic;
    using System.Linq;

    namespace Sample
    {
        public class ArrayIntersection : ArrayIntersectionTest
        {
            public override IEnumerable<int> CalculateArrayIntersection(int[] inArr1, int[] inArr2)
            {
                var temp = new List<int>();

                foreach (var i in inArr1)
                {
                    foreach (var j in inArr2)
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
        public class ArrayIntersection : ArrayIntersectionTest
        {
            public override IEnumerable<int> CalculateArrayIntersection(int[] inArr1, int[] inArr2)
            {
                return inArr1.Intersect(inArr2).Distinct();
            }
        }
    }
}