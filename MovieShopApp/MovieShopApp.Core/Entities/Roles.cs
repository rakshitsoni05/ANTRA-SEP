using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Roles
{
    public int Id { get; set; }
    [Column(TypeName = "nvarchar(20)")]
    public string Name { get; set; }
    
}