namespace Sample
{
    using System.Linq;
    using Tests;

    public class First_Missing_Positive_1 : FirstMissingPositiveTest
    {
        public override int FirstMissingPositive(int[] input)
        {
            var temp = 1;

            while (true)
            {
                var flag = false;
                foreach (var i in input)
                {
                    if (!flag && i == temp)
                    {
                        flag = true;
                    }
                }

                if (!flag)
                {
                    return temp;
                }

                temp++;
            }
        }
    }

    public class First_Missing_Positive_2 : FirstMissingPositiveTest
    {
        public override int FirstMissingPositive(int[] input)
        {
            var temp = input.ToList();
            var i = 1;

            while (temp.Contains(i))
            {
                i++;
            }

            return i;
        }
    }
}