namespace Sample
{
    using System.Collections.Generic;
    using Tests;

    public class Big_Number : BigNumberTest
    {
        public override string Add(string left, string right)
        {
            string returning = "";
            Stack<int> left_reversed = new Stack<int>();
            Stack<int> right_reversed = new Stack<int>();

            foreach (var c in left)
            {
                left_reversed.Push(int.Parse(c.ToString()));
            }
            foreach (var c in right)
            {
                right_reversed.Push(int.Parse(c.ToString()));
            }

            bool stop = false;
            int addMe = 0;
            int carry = 0;
            int innerLeft = 0;
            int innerRight = 0;
            int tempSum = 0;

            while (!stop)
            {
                bool left_value = left_reversed.TryPop(out innerLeft);
                bool right_value = right_reversed.TryPop(out innerRight);

                if (left_value || right_value || carry != 0)
                {
                    innerLeft = left_value ? innerLeft : 0;
                    innerRight = right_value ? innerRight : 0;

                    tempSum = innerLeft + innerRight;

                    int tempCarry = 0;
                    while (tempSum >= 10)
                    {
                        tempSum -= 10;
                        tempCarry += 1;
                    }
                    addMe = tempSum + carry;
                    carry = tempCarry;

                    returning = returning.Insert(0, addMe.ToString());
                }
                else
                {
                    break;
                }
            }

            return returning;
        }

        public override string Subtract(string left, string right)
        {
            string returning = "";
            Stack<int> left_reversed = new Stack<int>();
            Stack<int> right_reversed = new Stack<int>();

            foreach (var c in left)
            {
                left_reversed.Push(int.Parse(c.ToString()));
            }
            foreach (var c in right)
            {
                right_reversed.Push(int.Parse(c.ToString()));
            }

            bool stop = false;
            int addMe = 0;
            int carry = 0;
            int innerLeft = 0;
            int innerRight = 0;
            int tempSum = 0;

            while (!stop)
            {
                bool left_value = left_reversed.TryPop(out innerLeft);
                bool right_value = right_reversed.TryPop(out innerRight);

                if (left_value || right_value || carry != 0)
                {
                    innerLeft = left_value ? innerLeft : 0;
                    innerRight = right_value ? innerRight : 0;

                    tempSum = innerLeft - innerRight;

                    if (tempSum < 0)
                    {
                        tempSum += 10;
                        addMe = tempSum + carry;

                        carry = -1;
                    }
                    else
                    {
                        addMe = tempSum + carry;
                        carry = 0;
                    }
                    returning = returning.Insert(0, addMe.ToString());
                }
                else
                {
                    break;
                }
            }

            return returning.TrimStart('0');
        }

        public override string Multiply(string left, string right)
        {
            List<string> addlist = new List<string>();

            string rightzeros = "";
            for (int i = right.Length - 1; i >= 0; i--)
            {
                string leftzeros = "";
                for (int j = left.Length - 1; j >= 0; j--)
                {
                    addlist.Add(
                        (int.Parse(right[i].ToString() + rightzeros)
                        * int.Parse(left[j].ToString())
                        ).ToString() + leftzeros);
                    leftzeros += "0";
                }
                rightzeros += "0";
            }

            string total = "";
            foreach (string adding in addlist)
            {
                total = Add(total, adding);
            }

            return total;
        }

        public override string Divide(string top, string bottom)
        {
            throw new System.NotImplementedException();
        }
    }
}