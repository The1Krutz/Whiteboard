
//namespace WhiteBoard
//{
//    using System.Collections.Generic;
//    using System.Linq;

//    public class Sample2 : AnswerBase
//    {
//        public override IEnumerable<int> ArrayMissingNumber(int[] inArr) =>
//            Enumerable
//                .Range(inArr.Min(), inArr.Max() - inArr.Min())
//                .Where(z => !inArr.Contains(z));

//        public override string FindFirstDuplicateChar(string inString)
//        {
//            var temp = new HashSet<char>();

//            foreach (var t in inString)
//            {
//                if (!temp.Add(t))
//                {
//                    return t.ToString();
//                }
//            }

//            return "";
//        }

//        public override int FirstMissingPositive(int[] inArr)
//        {
//            var temp = inArr.ToList();
//            var i = 1;

//            while (temp.Contains(i))
//            {
//                i++;
//            }

//            return i;
//        }
//    }
//}
