using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie //this is a model for the database
    {
        public int ID { get; set; }

        //string Title initialzed to an empty string
        [StringLength(60, MinimumLength = 3)]//min and max string length
        [Required]
        public string Title { get; set; } = string.Empty;

        //The [Display] attribute specifies the display name of a field.
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)] //get date only, not time, from the date type
        public DateTime ReleaseDate { get; set; }

        //[Display(Name = "Movie Genre")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]//limits x-ters to be input. Must only use letters
        // first letter must be uppercase. White spaces are allowed, no numbers & special characters
        [Required]
        [StringLength(30)]//maximum length of a string property
        public string Genre { get; set; } = string.Empty;

        //enables Entity Framework Core to correctly map Price to currency in the database.
        [Range(1, 100)]//constrains a value to within a specified range
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, 100000000)]
        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public String Rating { get; set; } = string.Empty;

        public ICollection<Cast> Casts { get; set;}
    }
}
