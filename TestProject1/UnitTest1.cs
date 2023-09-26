using C__Methods;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetUserFullName()
        {
            string expected = "Söderberg, Anders";
            string actual = Methods.GetUserFullName("Anders", "Söderberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetUserFullNameForTesting()
        {
            string expected = "SÖDERBERG, Anders";
            string actual = Methods.GetUserFullNameForTesting("anders", "söderberg");
            Assert.Equal(expected, actual);
        }
    }
}