namespace Sample
{
    using Tests;

    public class Base_Ten_to_Two_1 : BaseTentoTwoTest
    {
        public override string BaseTentoTwo(int input)
        {
            if (input == 0)
            {
                return "0";
            }

            int powerOfTwo = 1;
            while (powerOfTwo * 2 <= input)
            {
                powerOfTwo *= 2;
            }

            string output = "";
            int dividend;

            do
            {
                dividend = input / powerOfTwo;
                input %= powerOfTwo;

                output += dividend;

                powerOfTwo /= 2;
            } while (powerOfTwo > 0);

            return output;
        }
    }

    public class Base_Ten_to_Two_2 : BaseTentoTwoTest
    {
        public override string BaseTentoTwo(int input)
        {
            int toBase = 2;
            string result = "";
            do
            {
                result = "0123456789ABCDEF"[input % toBase] + result;
                input /= toBase;
            }
            while (input > 0);

            return result;
        }
    }

    public class Base_Ten_to_Two_3 : BaseTentoTwoTest
    {
        public override string BaseTentoTwo(int input)
        {
            string result = "";
            do
            {
                result = (input % 2) + result;
                input /= 2;
            }
            while (input > 0);

            return result;
        }
    }
}
