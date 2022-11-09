using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Review
    {
        public int Id { get; set; }

        [ForeignKey("MovieId")]  
        public Movie Movie { get; set; } 
        public int MovieId { get; set; }  
        
        public string Title { get; set; }
        public string UserReview { get; set; }

    }
}
