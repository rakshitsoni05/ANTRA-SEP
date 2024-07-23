using System.ComponentModel.DataAnnotations.Schema;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Core.Model.Response;

public class TrailerResponseModel
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    
    [Column(TypeName = "nvarchar(2084)")]
    public string Name { get; set; }
    
    [Column(TypeName = "nvarchar(2084)")]
    public string TrailerUrl { get; set; }
    
    public Movies Movie { get; set; }
}