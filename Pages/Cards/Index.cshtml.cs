using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FinalUnique.Models;

namespace FinalUnique.Pages.Cards
{
    public class IndexModel : PageModel
    {
        private readonly CardContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<Card> Cards {get; set;}

        public IndexModel(CardContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Cards = _context.Card.ToList();
        }
    }
}