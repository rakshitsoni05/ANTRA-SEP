using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Reviews
{
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedDate { get; set; }
    
    [Column(TypeName = "decimal(3,2)")]
    public decimal Rating { get; set; }
    public string ReviewText { get; set; }
    
    public Movies Movie { get; set; }
    public Users User { get; set; }
    
}