using Microsoft.AspNetCore.Identity;

namespace RideOn.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string FullName { get; set; } = null!;
    public string? ProfilePictureUrl { get; set; }
    // public string? PreferredLanguage { get; set; }
    public string? Country { get; set; }
    // public double Rating { get; set; } = 5.0;
    public int TotalTrips { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
