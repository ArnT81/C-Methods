namespace TestProject1
{
    public class UnitTest1 : C__Methods.Methods
    {
        [Fact]
        public void TestGetUserFullName()
        {
            string expected = "Söderberg, Anders";
            string actual = GetUserFullName("Anders", "Söderberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetUserFullNameForTesting()
        {
            string expected = "SÖDERBERG, Anders";
            string actual = GetUserFullNameForTesting("anders", "söderberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test1()
        {
            string expected = "#_Hawthorne, Nathaniel (HAWNAT)";
            string actual = OptionalAssignmentFormatter("nathaniel", "hawthorne");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            string expected = "#_George, Elisabeth (GEOELI)";
            string actual = OptionalAssignmentFormatter("ELisabeth", "GEorge");
            Assert.Equal(expected, actual);
        }
    }
}