using RideOn.Application.Common.DTOs;

namespace RideOn.Application.Common.Interfaces.Services.IAuth;

public interface IAuthService
{
    Task<AuthResponse> RegisterRiderAsync(RegisterRiderRequest request);
    Task<AuthResponse> AuthenticateRiderAsync(LoginRequest loginRequest);
    Task<AuthResponse> RefreshTokenAsync(string token);
    Task<bool> RevokeTokenAsync(string token);
}
