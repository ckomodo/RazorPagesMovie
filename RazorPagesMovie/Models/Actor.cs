using Microsoft.Build.Framework;

namespace RazorPagesMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public int LastName { get; set; }       
        public string? PlayingAs { get; set; } //actor's character's name in the movie


    }
}
