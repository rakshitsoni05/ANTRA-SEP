using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Genres
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(24)")]
    public string Name { get; set; }
    
    public ICollection<MovieGenres> MovieGenres { get; set; }
    
}