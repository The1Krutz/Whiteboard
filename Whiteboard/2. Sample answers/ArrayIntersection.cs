
namespace Sample_Answers
{
    using Questions;
    using Tests;
    using System.Collections.Generic;
    using System.Linq;

    public class Sample1_ArrayIntersection : IArrayIntersection
    {
        public IEnumerable<int> ArrayIntersection(int[] inArr1, int[] inArr2)
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

    public class Sample2_ArrayIntersection : IArrayIntersection
    {
        public IEnumerable<int> ArrayIntersection(int[] inArr1, int[] inArr2)
        {
            return inArr1.Intersect(inArr2).Distinct();
        }
    }
    
    public class Sample1_ArrayIntersectionTests : ArrayIntersectionTest
    {
        public Sample1_ArrayIntersectionTests()
        {
            implementation = new Sample1_ArrayIntersection();
        }
    }

    public class Sample2_ArrayIntersectionTests : ArrayIntersectionTest
    {
        public Sample2_ArrayIntersectionTests()
        {
            implementation = new Sample2_ArrayIntersection();
        }
    }
}