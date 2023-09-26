namespace TestProject1
{
    public class OptionalAssignmentTest : C__Methods.Methods
    {
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
