namespace Questions
{
    /**
     * Write a class that implements the basic math operators that allow for numbers of unlimited size.
     */
    public interface IBigNumber
    {
        string Add(string left, string right);
        string Divide(string top, string bottom);
        string Multiply(string left, string right);
        string Subtract(string left, string right);
    }
}

namespace Tests
{
    using Questions;
    using Xunit;

    public abstract class BigNumberTest : IBigNumber
    {
        public abstract string Add(string left, string right);
        public abstract string Divide(string top, string bottom);
        public abstract string Multiply(string left, string right);
        public abstract string Subtract(string left, string right);

        public static TheoryData<string, string, string> Data_Add =>
            new TheoryData<string, string, string>
            {
                { "1", "2", "3" }, // small proof
                { "65535", "65535", "131070" }, // larger than a ushort can handle
                { "65535", "5535", "71070" }, // larger than a ushort can handle, but with different length strings
                { "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", "1234567890246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780" }, // larger than a double can handle, and with different length strings
            };

        public static TheoryData<string, string, string> Data_Divide =>
            new TheoryData<string, string, string>
            {
                {"6","3","2" }, // small proof
                {"196605","5","65535" }, // larger than a ushort can handle
            };

        public static TheoryData<string, string, string> Data_Multiply =>
            new TheoryData<string, string, string>
            {
                {"2","3","6" }, // small proof 
                {"65535","3","196605" }, // larger than a ushort can handle
                {"65535","65535","4294836225" }, // larger than a ushort can handle
            };

        public static TheoryData<string, string, string> Data_Subtract =>
            new TheoryData<string, string, string>
            {
                {"3","2","1" }, // small proof
                {"131070","65535","65535" }, // larger than a ushort can handle
                {"71070", "65535", "5535" }, // larger than a ushort can handle, but with different length strings
                {"1234567890246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780246913578024691357802469135780","1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890"  }, // larger than a double can handle, and with different length strings
            };

        [Theory]
        [MemberData(nameof(Data_Add))]
        public void Test_Add(string left, string right, string expected)
        {
            Assert.Equal(expected, Add(left, right));
        }

        [Theory(Skip = "not implemented yet")]
        [MemberData(nameof(Data_Divide))]
        public void Test_Divide(string left, string right, string expected)
        {
            Assert.Equal(expected, Divide(left, right));
        }

        [Theory(Skip = "not implemented yet")]
        [MemberData(nameof(Data_Multiply))]
        public void Test_Multiply(string left, string right, string expected)
        {
            Assert.Equal(expected, Multiply(left, right));
        }

        [Theory]
        [MemberData(nameof(Data_Subtract))]
        public void Test_Subtract(string left, string right, string expected)
        {
            Assert.Equal(expected, Subtract(left, right));
        }
    }
}
