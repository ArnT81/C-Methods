using static C__Methods.TicketOfficeAssignment;

namespace C__Methods
{
    public class Ticket
    {
        public int Age { get; set; }
        public Enum LocalPlace { get; set; }
        public int Number { get; set; }


        public Ticket(int age, Enum place)
        {
            Age = age;
            LocalPlace = place;
            Number = TicketNumberGenerator();
            Console.WriteLine(Place.Seated);
        }

        //public int Price(int? age, Enum? place)
        public int Price()
        {
            int cost;

            if (LocalPlace.ToString() == Place.Seated.ToString())
            {
                cost = Age switch
                {
                    <= 11 => 50,
                    >= 65 => 100,
                    _ => 170
                };
            }
            else
            {
                cost = Age switch
                {
                    <= 11 => 25,
                    >= 65 => 60,
                    _ => 110
                };
            }
            return cost;
        }

        public decimal Tax(int price) => Convert.ToDecimal((1 - 1 / 1.057) * price);
    }
}