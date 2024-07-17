using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Movies
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(2084)")]
    public string? BackDropUrl { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal? Budget { get; set; }
    
    public string? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    
    [Column(TypeName = "nvarchar(2084)")]
    public string? ImdbUrl { get; set; }
    
    [Column(TypeName = "nvarchar(64)")]
    public string? OriginalLanguage { get; set; }
    public string? Overview { get; set; }
    
    [Column(TypeName = "nvarchar(2084)")]
    public string?PosterUrl { get; set; }
    
    [Column(TypeName = "decimal(5,2)")]
    public decimal? Price { get; set; }
    
    public DateTime ReleaseDate { get; set; }
    
    [Column(TypeName = "decimal(18,4)")]
    public decimal? Revenue { get; set; }
    
    public int? Runtime { get; set; }
    
    [Column(TypeName = "nvarchar(512)")]
    public string? Tagline { get; set; }
    
    [Column(TypeName = "nvarchar(256)")]
    public string? Title { get; set; }
    
    [Column(TypeName = "nvarchar(2084)")]
    public string? TmdbUrl { get; set; }
    
    public string? UbdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
