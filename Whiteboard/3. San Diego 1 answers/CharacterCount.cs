namespace SanDiego3
{
    using Tests;

    namespace Justin
    {
        using System.Collections.Generic;

        /**
         * made class private to hide it from the tests
         */
        class Character_Count : CharacterCountTest
        {
            public override Dictionary<char, int> CharacterCount(string inputString)
            {
                int letterCount = 0;
                Dictionary<char, int> myFirstDictionary = new Dictionary<char, int>();

                // remove all spaces
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == ' ')
                    {
                        inputString = inputString.Remove(i, 1);

                    }
                }
                // lowercasing becuase reasons?
                inputString = inputString.ToLower();

                for (int i = 0; i < inputString.Length; i++)
                {
                    letterCount = 0;
                    for (int j = 0; j < inputString.Length; j++)
                    {

                        if (inputString[i] == inputString[j])
                        {
                            letterCount++;
                        }


                    }
                    if (myFirstDictionary.ContainsKey(inputString[i]))
                    {
                        continue;
                    }
                    myFirstDictionary.Add(inputString[i], letterCount);
                }

                // I commented this becuase it's pointless -Thomas
                // foreach (char letter in myFirstDictionary.Keys)
                // {
                //     Console.WriteLine("{0}: {1}", letter, myFirstDictionary[letter]);
                // }

                return myFirstDictionary; // I added this line so this code fit the method signature -Thomas
            }
        }
    }
}