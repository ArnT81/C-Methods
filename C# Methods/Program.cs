using C__Methods;
using static C__Methods.TicketOfficeAssignment;

//Console.WriteLine($"You have entered the name {Methods.GetUserName()}"); // 1
//Console.WriteLine(Methods.GetUserWord()); // 2
//Console.WriteLine($"You have entered {Methods.GetUserNumberAsString("Please enter a number")}"); // 3
//Console.WriteLine($"You have entered {Methods.GetUserWordWithArgument("number")}"); // 4
//Console.WriteLine(Methods.GetUserFullName("Anders", "Söderberg")); //5

// TICKET OFFICE ASSIGNMENT
//Console.WriteLine(TicketOfficeAssignment.BuyTicket()); //No longer working since refactoring assignment
//Console.WriteLine("\nNEW placeList: " + TicketOfficeAssignment.occupiedList); //No longer working since refactoring assignment

//Ticket ticket = new Ticket(65, Place.Standing);
//Ticket ticket2 = new Ticket(65, Place.Seated);

//Console.WriteLine("ticket.Age " + ticket.Age);
//Console.WriteLine("ticket.Place " + ticket.LocalPlace);
//Console.WriteLine("ticket.Price() " + ticket.Price());
//Console.WriteLine("ticket.Tax() " + ticket.Tax(ticket.Price()));

//Console.WriteLine("\nticket2.Age " + ticket2.Age);
//Console.WriteLine("ticket2.Place " + ticket2.LocalPlace);
//Console.WriteLine("ticket2.Price() " + ticket2.Price());
//Console.WriteLine("ticket2.Tax() " + ticket2.Tax(ticket2.Price()));

//List<Ticket> arne = new List<Ticket> {
//    new Ticket(11, Place.Standing),
//    new Ticket(64, Place.Standing),
//    new Ticket(65, Place.Standing),
//    new Ticket(11, Place.Seated),
//    new Ticket(64, Place.Seated),
//    new Ticket(65, Place.Seated)
//};



TicketSalesManager manager = new TicketSalesManager();

manager.AddTicket(new Ticket(11, Place.Standing));
manager.AddTicket(new Ticket(64, Place.Standing));
manager.AddTicket(new Ticket(65, Place.Standing));
manager.AddTicket(new Ticket(11, Place.Seated));
manager.AddTicket(new Ticket(64, Place.Seated));
manager.AddTicket(new Ticket(65, Place.Seated));
manager.AddTicket(new Ticket(65, Place.Seated));


Ticket ticketToRemove = manager.LocalTickets.Where(t => t.Number == 1).First();

Console.WriteLine("SalesTotal: " + manager.SalesTotal());
Console.WriteLine("RemoveTicket " + manager.RemoveTicket(ticketToRemove));
Console.WriteLine("AmountOfTickets: " + manager.AmountOfTickets());