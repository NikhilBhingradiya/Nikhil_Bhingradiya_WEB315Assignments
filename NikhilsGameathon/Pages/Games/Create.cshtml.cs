#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NikhilsGameathon.Models;

namespace NikhilsGameathon.Pages_Games
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesGamesContext _context;

        public CreateModel(RazorPagesGamesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Games Games { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Games.Add(Games);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
