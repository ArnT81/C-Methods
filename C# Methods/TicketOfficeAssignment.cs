namespace C__Methods
{
    public static class TicketOfficeAssignment
    {
        public static string BuyTicket()
        {
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you prefer a standing or seated ticket?");
            string? place = Console.ReadLine();

            if (place != "standing" && place != "seated") return "You need to enter 'standing' or 'seated' to continue you purchase";

            int ticketNr = TicketNumberGenerator();
            int price = PriceSetter(age, place);
            decimal tax = TaxCalculator(price);

            return $"Ticket nr: {ticketNr}\nprice: {price} SEK\nvat included: {tax} SEK\n";
        }

        private static int PriceSetter(int age, string place)
        {
            if (place.ToLower() == "seated")
            {
                switch (age)
                {
                    case <= 11:
                        return 50;
                    case >= 65:
                        return 100;
                    default:
                        return 170;
                }
            }
            else
            {
                switch (age)
                {
                    case <= 11:
                        return 25;
                    case >= 65:
                        return 60;
                    default:
                        return 110;
                }
            }
        }

        private static decimal TaxCalculator(int price) => Convert.ToDecimal((1 - 1 / 1.057) * price);
        private static int TicketNumberGenerator() => new Random().Next(0, 8001);
    }
}
