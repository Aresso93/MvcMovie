using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public record MovieDTO(int Id, string Title, DateTime ReleaseDate, decimal Price, Rating Rating, string Genre);
   
}
