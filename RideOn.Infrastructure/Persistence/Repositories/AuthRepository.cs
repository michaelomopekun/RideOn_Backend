using Microsoft.AspNetCore.Identity;
using RideOn.Application.Common.Interfaces;
using RideOn.Application.Common.Interfaces.Persistence.Auth;
using RideOn.Domain.Entities;
using RideOn.Infrastructure.Data;

namespace RideOn.Infrastructure.Persistence.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly RideOnDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;


    public AuthRepository(RideOnDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public Task<bool> CheckPasswordAsync(Rider rider, string password)
    {
        
        throw new NotImplementedException();
    }

    public Task<Rider> RegisterRiderAsync(Rider rider)
    {
        throw new NotImplementedException();
    }
}
