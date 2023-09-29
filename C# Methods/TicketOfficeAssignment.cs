using System;
using System.Linq;

namespace C__Methods
{
    public static class TicketOfficeAssignment
    {
        static public string occupiedList = "34,1003,389,4100,4890,7233,2855";

        public static string BuyTicket()
        {
            int age = GetCustomerAge();
            string place = GetCustomerPlacePreference();
            int ticketNr = TicketNumberGenerator();
            bool vacant = CheckPlaceAvailability(occupiedList, ticketNr);

            while (!vacant)
            {
                ticketNr = TicketNumberGenerator();
                vacant = CheckPlaceAvailability(occupiedList, ticketNr);
            }

            occupiedList = AddPlace(occupiedList, ticketNr);
            int price = PriceSetter(age, place);
            decimal tax = TaxCalculator(price);

            return $"Ticket nr: {ticketNr}\nprice: {price} SEK\nvat included: {tax} SEK\n";
        }

        public static int PriceSetter(int age, string place)
        {
            int cost;

            if (place.ToLower() == "seated")
            {
                cost = age switch
                {
                    <= 11 => 50,
                    >= 65 => 100,
                    _ => 170
                };
            }
            else
            {
                cost = age switch
                {
                    <= 11 => 25,
                    >= 65 => 60,
                    _ => 110
                };
            }
            return cost;
        }

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

        private static string GetCustomerPlacePreference()
        {
            bool invalid = true;
            string place;
            Console.WriteLine("Would you prefer a standing or seated ticket?");

            do
            {
                place = Console.ReadLine() ?? "";
                if (place.ToLower() == "seated" || place.ToLower() == "standing") invalid = false;
                else Console.WriteLine("You need to enter \"standing\" or \"seated\" to continue you purchase");
            } while (invalid);

            return place;
        }

        private static decimal TaxCalculator(int price) => Convert.ToDecimal((1 - 1 / 1.057) * price);
        private static int TicketNumberGenerator() => new Random().Next(0, 8001);
        private static bool CheckPlaceAvailability(string placeList, int placeNumber) => !placeList.Contains(placeNumber.ToString());
        private static string AddPlace(string placeList, int placeNumber) => string.Join(",", placeList, $"{placeNumber},");
    }
}
