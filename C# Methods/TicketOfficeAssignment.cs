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

        public static int PriceSetter(int age, string place)
        {
            int result;

            if (place.ToLower() == "seated")
            {
                result = age switch
                {
                    <= 11 => 50,
                    >= 65 => 100,
                    _ => 170
                };
            }
            else
            {
                result = age switch
                {
                    <= 11 => 25,
                    >= 65 => 60,
                    _ => 110
                };
            }
            return result;
        }

        private static decimal TaxCalculator(int price) => Convert.ToDecimal((1 - 1 / 1.057) * price);
        private static int TicketNumberGenerator() => new Random().Next(0, 8001);
    }
}
