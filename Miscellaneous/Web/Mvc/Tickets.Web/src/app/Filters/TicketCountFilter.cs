using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tickets.Data.Services;

namespace Tickets.Web.Filters
{
    public class TicketCountFilter : IPageFilter
    {
        private readonly ITicketService _ticketService;

        public TicketCountFilter(ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }
        
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            OnPageHandler(null);
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            OnPageHandler(context.Result);
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            OnPageHandler(context.Result);
        }

        private void OnPageHandler(IActionResult result)
        {
            var pageResult = result as PageResult;
            if (pageResult != null)
            {
                pageResult.ViewData["TicketCount"] = this._ticketService.GetTicketCount();
            }
        }
    }
}