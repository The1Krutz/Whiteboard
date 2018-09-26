
namespace Bragg5
{
    using Tests;

    namespace Gabriel
    {
        using System;

        /**
         * private to hide from tests (since it throws exceptions instead of returning "" like I expected when I wrote the tests)
         */
        class Find_First_Duplicate_Char : FindFirstDuplicateCharTest
        {
            public override string FindFirstDuplicateChar(string input)
            {
                int duplicateIndex = -1;
                char[] array = input.ToCharArray();
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            // stores the duplicate's index if 1) it's the first duplicate encounterred 2) if it appears in the string before the previously saved duplicate does.
                            if (duplicateIndex == -1 || j < duplicateIndex)
                            {
                                // stores the duplicated char's index
                                duplicateIndex = j;
                            }
                        }
                    }
                }
                // if duplicateIndex's value hasn't changed then no duplicates were encountered.
                if (duplicateIndex == -1)
                {
                    throw new Exception("No duplicate characters were found");
                }
                else
                {
                    return array[duplicateIndex].ToString(); // I added .tostring() -thomas
                }
            }
        }
    }
}
