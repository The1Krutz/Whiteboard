
namespace SanDiego3_Answers
{
    using Questions;
    using System.Collections.Generic;
    using Tests;

    public class Justin_CharacterCount : ICharacterCount
    {
        public Dictionary<char, int> CharacterCount(string inputString)
        {
            int letterCount = 0;
            Dictionary<char, int> myFirstDictionary = new Dictionary<char, int>();

            // removes all spaces from the string
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                {
                    inputString = inputString.Remove(i, 1);

                }
            }
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

    public class Justin_CharacterCountTests : CharacterCountTest
    {
        public Justin_CharacterCountTests()
        {
            implementation = new Justin_CharacterCount();
        }
    }
}