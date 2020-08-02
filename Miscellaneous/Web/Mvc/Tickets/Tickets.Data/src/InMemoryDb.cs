using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tickets.Data.Models;

namespace Tickets.Data
{
    public sealed class InMemoryDb
    {
        public List<Ticket> Tickets { get; }

        public InMemoryDb()
        {
            this.Tickets = new List<Ticket>();
            this.Tickets.Add(new Ticket() { Id = 1, Subject = "Ticket #1", Description = "I need help #1" });
            this.Tickets.Add(new Ticket() { Id = 1, Subject = "Ticket #1", Description = "I need help #1" });
            this.Tickets.Add(new Ticket() { Id = 1, Subject = "Ticket #1", Description = "I need help #1" });
        }
    }
}