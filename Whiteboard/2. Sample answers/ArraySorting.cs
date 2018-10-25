namespace Sample
{
    using Tests;

    public class Array_Sort_Bubble : ArraySortTest
    {
        public override int[] ArraySort(int[] input)
        {
            bool stop = false, changedThisPass = false;
            int buffer, index = 0;

            do
            {
                if (input[index] > input[index + 1])
                {
                    buffer = input[index];
                    input[index] = input[index + 1];
                    input[index + 1] = buffer;
                    changedThisPass = true;
                }

                index++;
                if (index > input.Length - 2)
                {
                    index = 0;
                    if (changedThisPass)
                    {
                        changedThisPass = false;
                    }
                    else
                    {
                        stop = true;
                    }
                }
            } while (!stop);

            return input;
        }
    }
}