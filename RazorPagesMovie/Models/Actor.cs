using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; } 
        public int MovieId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }       
        public string? PlayingAs { get; set; } //actor's character's name in the movie

        public ICollection<Cast> Casts { get; set;}

    }
}
