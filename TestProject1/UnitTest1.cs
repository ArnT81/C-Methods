namespace TestProject1
{
    public class UnitTest1 : Methods.Methods
    {
        [Fact]
        public void TestGetUserFullName()
        {
            //var methods = new Methods.Methods();
            string expected = "Söderberg, Anders";
            string actual = GetUserFullName("Anders", "Söderberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetUserFullNameForTesting()
        {
            //var methods = new Methods.Methods();
            string expected = "SÖDERBERG, Anders";
            string actual = GetUserFullNameForTesting("anders", "söderberg");
            Assert.Equal(expected, actual);
        }
    }
}