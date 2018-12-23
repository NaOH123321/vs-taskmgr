using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vstaskmgr.Model;
using vstaskmgr.Services;

namespace vstaskmgr.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        private readonly QuoteService _quoteService;

        public QuotesController(QuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quoteService.GetQuoteList();
        }

        // GET api/Quotes/5
        [HttpGet("{id}")]
        public Quote Get(int id)
        {
            var qList = _quoteService.GetQuoteList();
            Random r = new Random();
            int n = r.Next(_quoteService.GetQuoteList().Count);
            return qList.ElementAt(n);
        }
    }
}
