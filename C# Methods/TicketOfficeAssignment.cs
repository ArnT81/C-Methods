namespace C__Methods
{
    public static class TicketOfficeAssignment
    {
        static public string occupiedList = "34,1003,389,4100,4890,7233,2855";
        public enum Place
        {
            Standing,
            Seated
        }

        public static string BuyTicket()
        {
            int age = GetCustomerAge();
            Place place = GetCustomerPlacePreference();
            //int ticketNr = TicketNumberGenerator();
            //bool vacant = CheckPlaceAvailability(occupiedList, ticketNr);

            //while (!vacant)
            //{
            //    ticketNr = TicketNumberGenerator();
            //    vacant = CheckPlaceAvailability(occupiedList, ticketNr);
            //}

            //occupiedList = AddPlace(occupiedList, ticketNr);


            //var ticket = new Ticket();

            //int price = Ticket.Price(age, place);

            //int price = ticket.Price();

            //decimal tax = TaxCalculator(price);

            //return $"Ticket nr: {ticketNr}\nprice: {price} SEK\nvat included: {tax} SEK\n";
            return "Temp";
        }

        //public static int Price(int age, Place place)
        //{
        //    int cost;

        //    if (place == Place.Seated)
        //    {
        //        cost = age switch
        //        {
        //            <= 11 => 50,
        //            >= 65 => 100,
        //            _ => 170
        //        };
        //    }
        //    else
        //    {
        //        cost = age switch
        //        {
        //            <= 11 => 25,
        //            >= 65 => 60,
        //            _ => 110
        //        };
        //    }
        //    return cost;
        //}

        private static int GetCustomerAge()
        {
            bool invalid;
            int age;

            do
            {
                invalid = true;
                Console.WriteLine("What is your age");
                string? response = Console.ReadLine();
                if (int.TryParse(response, out age)) invalid = false;
                else Console.WriteLine("Invalid input, please enter a numerical value.");
            } while (invalid);

            return age;
        }

        private static Place GetCustomerPlacePreference()
        {
            bool invalid = true;
            string place;
            Console.WriteLine("Would you prefer a standing or seated ticket?");

            do
            {
                place = Console.ReadLine()?.ToLower() ?? "";
                if (place == Place.Standing.ToString().ToLower() || place == Place.Seated.ToString().ToLower()) invalid = false;
                else Console.WriteLine("You need to enter \"standing\" or \"seated\" to continue you purchase");
            } while (invalid);
            Console.WriteLine("PLACE" + place); //TEMP
            if (place == "seated") return Place.Seated;
            else return Place.Standing;
        }

        private static decimal TaxCalculator(int price) => Convert.ToDecimal((1 - 1 / 1.057) * price);
        //public static int TicketNumberGenerator() => new Random().Next(0, 8001);
        //private static bool CheckPlaceAvailability(string placeList, int placeNumber) => !placeList.Contains(placeNumber.ToString());
        //private static string AddPlace(string placeList, int placeNumber) => string.Join(",", placeList, $"{placeNumber},");
    }
}