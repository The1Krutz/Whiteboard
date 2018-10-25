namespace Sample
{
    using Tests;

    public class Remove_Character : RemoveCharacterTest
    {
        public override string RemoveCharacter(string input, char remove)
        {
            var temp = "";

            foreach (var c in input)
            {
                if (c != remove)
                {
                    temp += c;
                }
            }

            return temp;
        }
    }
}