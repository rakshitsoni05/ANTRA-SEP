using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Casts
{
    public int Id { get; set; }
    public string Gender { get; set; }
    [Column(TypeName = "nvarchar(128)")]
    public string Name { get; set; }
    [Column(TypeName = "nvarchar(2084)")]
    public string ProfilePath { get; set; }
    public string TmdbUrl { get; set; }
    
    public ICollection<MovieCasts> MovieCasts { get; set; }
    
}