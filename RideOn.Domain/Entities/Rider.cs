
namespace RideOn.Domain.Entities;

public class Rider
{
    public string Id { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string? ProfilePictureUrl { get; set; }
    // public string? PreferredLanguage { get; set; }
    public string? Country { get; set; }
    // public double Rating { get; set; } = 5.0;
    public int TotalTrips { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
