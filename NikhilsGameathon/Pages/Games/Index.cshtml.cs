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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesGamesContext _context;

        public IndexModel(RazorPagesGamesContext context)
        {
            _context = context;
        }

        public IList<Games> Games { get;set; }

        public async Task OnGetAsync()
        {
            Games = await _context.Games.ToListAsync();
        }
    }
}
