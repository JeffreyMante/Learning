using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tickets.Data.Models;
using Tickets.Data.Services;
using Tickets.Web.Filters;

namespace SupportTickets.Pages.Tickets
{
    public class IndexModel : PageModel
    {
        private readonly ITicketService _ticketService;

        public IEnumerable<Ticket> Tickets { get; private set; }

        public IndexModel(ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }

        public void OnGet()
        {
            Tickets = this._ticketService.GetAll();
        }
    }
}