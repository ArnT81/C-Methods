using C__Methods;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetUserFullName()
        {
            string expected = "S�derberg, Anders";
            string actual = Methods.GetUserFullName("Anders", "S�derberg");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetUserFullNameForTesting()
        {
            string expected = "S�DERBERG, Anders";
            string actual = Methods.GetUserFullNameForTesting("anders", "s�derberg");
            Assert.Equal(expected, actual);
        }
    }
}