using C__Methods;

namespace TestProject1
{
    public class TicketOfficeAssignmentTest
    {
        //Seated
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
