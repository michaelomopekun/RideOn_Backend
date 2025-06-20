namespace RideOn.Application.Common.DTOs;

public class RegisterRiderRequest
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    // public string ConfirmPassword { get; set; } = default!;
    public string Password { get; set; } = default!;
}
