
//namespace WhiteBoard
//{
//    using System;

//    public class Christopher : AnswerBase
//    {
//        /**
//         * Testable public interface
//         * base method with expression bodied method that redirects to custom implementation
//         */
//        public override string RemoveCharacter(string inString, char removeMe) => fn1(inString, removeMe);

//        /**
//         * Implementations pasted from student response
//         */
//        // problem 1
//        private string fn1(string inString, char removeMe)
//        {
//            string result = "";
//            char[] charrArr = inString.ToCharArray();

//            Console.WriteLine("Original String: {0}", inString);

//            for (int i = 0; i < charrArr.Length; i++)
//            {
//                if (charrArr[i] == removeMe)
//                {
//                    continue;
//                }
//                else
//                {
//                    result += charrArr[i].ToString();
//                }
//            }
//            return result;
//        }
//    }
//}
