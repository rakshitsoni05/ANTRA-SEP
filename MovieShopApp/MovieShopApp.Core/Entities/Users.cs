using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopApp.Core.Entities;

public class Users
{
    public int Id { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    [Column(TypeName = "nvarchar(256)")]
    public string Email { get; set; }
    
    [Column(TypeName = "nvarchar(128)")]
    public string FirstName { get; set; }
    
    [Column(TypeName = "nvarchar(1024)")]
    public string HashedPassword { get; set; }
    public bool IsLocked { get; set; }
    
    [Column(TypeName = "nvarchar(128)")]
    public string LastName { get; set; }
    
    [Column(TypeName = "nvarchar(16)")]
    public string PhoneNumber { get; set; }
    public string ProfilePictureUrl { get; set; }
    
    [Column(TypeName = "nvarchar(1024)")]
    public string Salt { get; set; }
}