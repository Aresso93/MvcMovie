
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    
    public class Movie
    {

        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
     
        public DateTime ReleaseDate { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        //[StringLength(30)]
        //public string? Genre { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }

        [Range(1,5)]
        public Rating Rating { get; set; }

      
        public Genre? Genre { get; set; } = null!;
        public int? GenreId { get; set; }
    }

    
}