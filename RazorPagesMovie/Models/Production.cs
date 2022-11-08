using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Production
    {
        public int Id { get; set; }
        [ForeignKey("MovieId")] 
        public Movie? Movie { get; set; } //property representing Movie entity
        public int MovieId { get; set; }
        
        public string? Producer { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public string? Costume { get; set; }
    }
}
