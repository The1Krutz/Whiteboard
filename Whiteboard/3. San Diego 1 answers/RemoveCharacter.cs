namespace SanDiego3
{
    using Tests;

    namespace Amanda
    {
        /**
         * made class private to hide it from the tests
         */
        class Remove_Character : RemoveCharacterTest
        {
            public override string RemoveCharacter(string input, char remove)
            {
                string temp = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != remove)
                    {
                        temp += input[i];
                    }
                }

                return temp;
            }
        }
    }

    namespace Christopher
    {
        /**
         * made class private to hide it from the tests
         */
        class Remove_Character : RemoveCharacterTest
        {
            public override string RemoveCharacter(string input, char remove)
            {
                string result = "";
                char[] charrArr = input.ToCharArray();

                for (int i = 0; i < charrArr.Length; i++)
                {
                    if (charrArr[i] == remove)
                    {
                        continue;
                    }
                    else
                    {
                        result += charrArr[i].ToString();
                    }
                }
                return result;
            }
        }
    }

    namespace Justin
    {
        /**
         * made class private to hide it from the tests
         */
        class Remove_Character : RemoveCharacterTest
        {
            public override string RemoveCharacter(string input, char remove)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == remove)
                    {
                        input = input.Remove(i, 1);

                        i--; // my addition based on conversation with justin -thomas
                    }
                }
                return input;
            }
        }
    }
}