namespace TestProject1
{
    public class UnitTest1 : Methods.Methods
    {
        [Fact]
        public void TestGetUserFullName()
        {
            //var methods = new Methods.Methods();
            string expected = "S�derberg, Anders";
            string actual = GetUserFullName("Anders", "S�derberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetUserFullNameForTesting()
        {
            //var methods = new Methods.Methods();
            string expected = "S�DERBERG, Anders";
            string actual = GetUserFullNameForTesting("anders", "s�derberg");
            Assert.Equal(expected, actual);
        }
    }
}