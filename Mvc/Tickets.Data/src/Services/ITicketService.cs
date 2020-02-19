using System.Collections.Generic;
using Tickets.Data.Models;

namespace Tickets.Data.Services
{
    public interface ITicketService
    {
        int GetTicketCount();
        IEnumerable<Ticket> GetAll();
        void Add(Ticket ticket);
        void Delete(Ticket ticket);
    }
}