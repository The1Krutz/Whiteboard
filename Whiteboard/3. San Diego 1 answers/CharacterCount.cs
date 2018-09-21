
namespace SanDiego3
{
    using Questions;
    using System.Collections.Generic;
    using Tests;

    namespace Justin
    {
        public class CharacterCount : CharacterCountTest
        {
            public override Dictionary<char, int> GetCharacterCount(string inputString)
            {
                int letterCount = 0;
                Dictionary<char, int> myFirstDictionary = new Dictionary<char, int>();

                /*
                 * commenting out some code because this solution never worked, and causes the tests to fail
                 * -Thomas
                 *
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
                */
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