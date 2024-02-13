using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public record MovieDTO(int Id, [property: Required] string Title, [property: DataType(DataType.Date)] DateTime ReleaseDate, [property: DataType(DataType.Currency)] decimal Price, [property: Range(1, 5)] Rating Rating, string Genre);

}
