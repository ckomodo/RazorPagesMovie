using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Cast
    {
        public int Id { get; set; } //what's the use of a GUID? 

        //[Required]
        //public string FirstName { get; set; } = String.Empty; //why is null required in this field?
        //[Required]
        //public string LastName { get; set; } = String.Empty;//why is null required in this field?

        [ForeignKey("MovieId")]  //should refer to an actor, not  
        public Movie? Movie { get; set; } //property representing Movie entity
        public int? MovieId { get; set; } //column representing FK r'ship with Movie table 

        //[ForeignKey("ActorId")]  
        //public Actor? Actor { get; set; }
        //public int? ActorId { get; set; }


    }
}
