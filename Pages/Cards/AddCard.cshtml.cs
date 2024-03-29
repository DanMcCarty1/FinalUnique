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
    public class CardModel : PageModel
    {
        private readonly CardContext _context;
        private readonly ILogger<CardModel> _logger;
        [BindProperty]
        public Card Card {get; set;}

        public CardModel(CardContext context, ILogger<CardModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {

        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Card.Add(Card);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}