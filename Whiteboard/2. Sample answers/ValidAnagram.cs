namespace Sample
{
    using Tests;

    namespace Sample
    {
        using System.Collections.Generic;
        using System.Linq;

        public class Valid_Anagram : ValidAnagramTest
        {
            public override bool ValidAnagram(string string1, string string2)
            {
                bool returning = true;
                string1 = string1.ToLowerInvariant();
                string2 = string2.ToLowerInvariant();

                List<char> alphabet = new List<char> {
                                 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                             };

                alphabet.ForEach(letter => returning = returning && string1.Count(z => z == letter) == string2.Count(z => z == letter));

                return returning;
            }
        }
    }
}