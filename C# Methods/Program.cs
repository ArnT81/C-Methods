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

Ticket ticket = new Ticket(65, Place.Standing);
Ticket ticket2 = new Ticket(65, Place.Seated);


Console.WriteLine("ticket.Age " + ticket.Age);
Console.WriteLine("ticket.Place " + ticket.LocalPlace);
Console.WriteLine("ticket.Number " + ticket.Number);
Console.WriteLine("ticket.Price() " + ticket.Price());
Console.WriteLine("ticket.Tax() " + ticket.Tax(ticket.Price()));

Console.WriteLine("\nticket2.Age " + ticket2.Age);
Console.WriteLine("ticket2.Place " + ticket2.LocalPlace);
Console.WriteLine("ticket2.Number " + ticket2.Number);
Console.WriteLine("ticket2.Price() " + ticket2.Price());
Console.WriteLine("ticket2.Tax() " + ticket2.Tax(ticket2.Price()));