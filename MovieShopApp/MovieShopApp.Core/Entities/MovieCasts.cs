using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class MovieCasts
{
    public int CastId { get; set; }
    [Column(TypeName = "nvarchar(450)")]
    public string Character { get; set; }
    public int MovieId { get; set; }
    
    public Casts Cast { get; set; }
    public Movies Movie { get; set; }
    
}