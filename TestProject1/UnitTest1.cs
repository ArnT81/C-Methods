using C__Methods;

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

        // TICKET OFFICE ASSIGNMENT
        [Fact]
        public void Under12AndSeated()
        {
            int expected = 50;
            int actual = TicketOfficeAssignment.PriceSetter(11, "seated");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Over64AndSeated()
        {
            int expected = 100;
            int actual = TicketOfficeAssignment.PriceSetter(65, "seated");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SeatedRest()
        {
            int expected = 170;
            int actual = TicketOfficeAssignment.PriceSetter(12, "seated");
            Assert.Equal(expected, actual);
        }

        //Standing
        [Fact]
        public void Under12AndStanding()
        {
            int expected = 25;
            int actual = TicketOfficeAssignment.PriceSetter(11, "standing");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Over64AndStanding()
        {
            int expected = 60;
            int actual = TicketOfficeAssignment.PriceSetter(65, "standing");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StandingRest()
        {
            int expected = 110;
            int actual = TicketOfficeAssignment.PriceSetter(12, "standing");
            Assert.Equal(expected, actual);
        }
    }
}