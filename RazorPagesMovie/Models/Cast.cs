using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Cast //this is a junction table
    {
        public int Id { get; set; }

        [ForeignKey("MovieId")]  //refers to a movie
        public Movie? Movie { get; set; } //property representing Movie entity
        public int MovieId { get; set; } //column representing FK r'ship with Movie table 

        [ForeignKey("ActorId")]
        public Actor? Actor { get; set; }
        public int? ActorId { get; set; }


    }
}
