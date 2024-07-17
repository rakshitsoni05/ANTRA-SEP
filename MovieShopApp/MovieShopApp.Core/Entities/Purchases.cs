using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Purchases
{
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public DateTime PurchasedDateTime { get; set; }
    public int PurchaseNumber { get; set; }
    
    [Column(TypeName = "decimal(5,2)")]
    public decimal TotalPrice { get; set; }
    
    public Movies Movie { get; set; }
    public Users User { get; set; }
}