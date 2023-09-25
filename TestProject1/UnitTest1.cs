namespace TestProject1
{
    public class UnitTest1 : C__Methods.Methods
    {
        [Fact]
        public void TestGetUserFullName()
        {
            string expected = "S�derberg, Anders";
            string actual = GetUserFullName("Anders", "S�derberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetUserFullNameForTesting()
        {
            string expected = "S�DERBERG, Anders";
            string actual = GetUserFullNameForTesting("anders", "s�derberg");
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