using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Genre
    {

        public int Id { get; set; } 

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string MovieGenre {  get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
