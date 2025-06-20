using Microsoft.AspNetCore.Identity.Data;
using RideOn.Domain.Entities;

namespace RideOn.Application.Common.Interfaces.Persistence.Auth;

public interface IAuthRepository
{
    Task<Rider> RegisterRiderAsync(Rider rider);
    Task<bool> CheckPasswordAsync(Rider rider, string password);

}
