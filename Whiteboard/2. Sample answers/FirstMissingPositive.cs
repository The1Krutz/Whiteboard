namespace Sample
{
    using Tests;

    namespace Sample
    {
        public class First_Missing_Positive : FirstMissingPositiveTest
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
    }

    namespace Sample2
    {
        using System.Linq;

        public class First_Missing_Positive : FirstMissingPositiveTest
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
}