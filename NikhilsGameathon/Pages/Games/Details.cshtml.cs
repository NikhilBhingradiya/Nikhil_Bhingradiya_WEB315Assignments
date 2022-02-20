#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NikhilsGameathon.Models;

namespace NikhilsGameathon.Pages_Games
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesGamesContext _context;

        public DetailsModel(RazorPagesGamesContext context)
        {
            _context = context;
        }

        public Games Games { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Games = await _context.Games.FirstOrDefaultAsync(m => m.ID == id);

            if (Games == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
