#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NikhilsGameathon.Models;

    public class RazorPagesGamesContext : DbContext
    {
        public RazorPagesGamesContext (DbContextOptions<RazorPagesGamesContext> options)
            : base(options)
        {
        }

        public DbSet<NikhilsGameathon.Models.Games> Games { get; set; }
    }
