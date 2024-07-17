namespace MovieShopApp.Core.Entities;

public class MovieGenres
{
    public int GenreId { get; set; }
    public int MovieId { get; set; }
    
    public Genres Genre { get; set; }
    
    public Movies Movie { get; set; }
    
}