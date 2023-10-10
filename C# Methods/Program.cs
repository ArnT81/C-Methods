using C__Methods;
using System.Text.Json;
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



//TicketSalesManager manager = new TicketSalesManager();

//manager.AddTicket(new Ticket(11, Place.Standing));
//manager.AddTicket(new Ticket(64, Place.Standing));
//manager.AddTicket(new Ticket(65, Place.Standing));
//manager.AddTicket(new Ticket(11, Place.Seated));
//manager.AddTicket(new Ticket(64, Place.Seated));
//manager.AddTicket(new Ticket(65, Place.Seated));
//manager.AddTicket(new Ticket(65, Place.Seated));


//Ticket ticketToRemove = manager.LocalTickets.Where(t => t.Number == 1).First();

//Console.WriteLine("SalesTotal: " + manager.SalesTotal());
//Console.WriteLine("RemoveTicket " + manager.RemoveTicket(ticketToRemove));
//Console.WriteLine("AmountOfTickets: " + manager.AmountOfTickets());



string concertData = File.ReadAllText("C:\\Users\\ArnTie\\Desktop\\lexicon\\Inlämningsuppgifter\\C#\\C# Methods\\C# Methods\\C# Methods\\concert_data.json");
List<Concert> concerts = JsonSerializer.Deserialize<List<Concert>>(concertData);

Console.WriteLine("All conserts");
Console.WriteLine(concertData + "\n");

//1. Return a new List<Concert> ordered by the Date value, going from the present date.
List<Concert> sortedConcerts = concerts.Where(b => b.Date > DateTime.Now).OrderBy(b => b.Date).ToList();
Console.WriteLine("upcoming concerts sorted by date");
foreach (var concert in sortedConcerts) Console.WriteLine(concert.Date);
Console.WriteLine();

//2. Return a new List<Concert> with all concerts of a ReducedVenue (true).
List<Concert> concertWithReducedVenue = concerts.Where(b => b.ReducedVenue == true).ToList();
Console.WriteLine("concerts with reduced venue");
foreach (var concert in concertWithReducedVenue) Console.WriteLine(concert.ReducedVenue);
Console.WriteLine();

//3.Return a new List<Concert> with all concerts during 2024.
List<Concert> concertsIn2024 = concerts.Where(b => b.Date.ToString().Contains("2024")).ToList();
Console.WriteLine("concerts in 2024");
foreach (var concert in concertsIn2024) Console.WriteLine(concert.Date);
Console.WriteLine();

//4. Return a new List<Concert> with the five biggest projected sales figures (the FullCapacitySales value).
List<Concert> biggestSalesFigures = concerts.OrderByDescending(b => b.FullCapacitySales).Take(5).ToList();
Console.WriteLine("5 biggest concerts by sales figures");
foreach (var concert in biggestSalesFigures) Console.WriteLine(concert.FullCapacitySales);
Console.WriteLine();

//5.Return a new List<Concert> with all concerts taking place on a Friday.
List<Concert> concertsOnFridays = concerts.Where(b => b.Date.DayOfWeek == DayOfWeek.Friday).ToList();
Console.WriteLine("concerts on fridays");
foreach (var concert in concertsOnFridays) Console.WriteLine(concert.Date.DayOfWeek);
Console.WriteLine();