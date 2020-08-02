using System.Collections.Generic;
using System.Linq;
using Tickets.Data.Models;

namespace Tickets.Data.Services
{
    public class TicketService : ITicketService
    {
        private readonly InMemoryDb _database;
        public TicketService(InMemoryDb database)
        {
            this._database = database;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return this._database.Tickets.ToList();
        }

        public int GetTicketCount()
        {
            return this._database.Tickets.Count();
        }

        public void Add(Ticket ticket)
        {
            this._database.Tickets.Add(ticket);
            ticket.Id = this._database.Tickets.Max(t => t.Id) + 1;
        }

        public void Delete(Ticket ticket)
        {
            var item = this._database.Tickets.SingleOrDefault(t => t.Id == ticket.Id);
            if (item != null)
            {
                this._database.Tickets.Remove(item);
            }
        }
    }
}