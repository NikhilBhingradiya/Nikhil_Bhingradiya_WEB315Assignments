using System;
using System.ComponentModel.DataAnnotations;

namespace NikhilsGameathon.Models
{
    public class Games
    {
        public int ID { get; set; }
        public string GamesName { get; set; }=default!;

        [DataType(DataType.Date)]
        public DateTime InitiallyReleaseDate { get; set; }
        public string Devloper { get; set; } = default!;
        public decimal platform { get; set; }
    }
}