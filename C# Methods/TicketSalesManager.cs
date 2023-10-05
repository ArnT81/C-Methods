using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static C__Methods.TicketOfficeAssignment;

namespace C__Methods
{
    public class TicketSalesManager
    {
        public List<Ticket> LocalTickets { get; set; } = new List<Ticket>();


        public int NextTicketNumber()
        {
            int suggested;

            if (LocalTickets.ToList().Count() < 1) suggested = 1;
            else suggested = new Random().Next(0, 8001);

            var occupied = LocalTickets.Where(t => t.Number == suggested).ToList().Count > 0;

            while (occupied)
            {
                suggested = new Random().Next(0, 8001);
                occupied = LocalTickets.Where(t => t.Number == suggested).ToList().Count > 0;
            }

            return suggested;
        }

        public Ticket AddTicket(Ticket ticket)
        {
            ticket.Number = NextTicketNumber();

            //Console.WriteLine($"ticket.Age {ticket.Age}");
            //Console.WriteLine($"$ticket.Place {ticket.LocalPlace}");
            //Console.WriteLine($"ticket.Number {ticket.Number}");
            //Console.WriteLine($"$ticket.TicketPrice {ticket.Price()}");

            LocalTickets.Add(ticket);
            return ticket;
        }

        public bool RemoveTicket(Ticket ticket)
        {
            if (ticket == null) return false;
            Console.WriteLine("In RemoveTicket, Removing: " + ticket.Number);
            LocalTickets.Remove(ticket);
            return true;
        }

        public decimal SalesTotal()
        {
            int total = 0;
            foreach (Ticket ticket in LocalTickets) total += ticket.Price();
            return total;
        }

        public int AmountOfTickets() => LocalTickets.Count();
    }
}