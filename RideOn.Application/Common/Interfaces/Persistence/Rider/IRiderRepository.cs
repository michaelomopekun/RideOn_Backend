using RideOn.Domain.Entities;

namespace RideOn.Application.Common.Interfaces.Persistence;

public interface IRiderRepository
{
    // checkes
    Task<bool> IsRiderExistsAsync(string riderId);
    Task<bool> IsRiderExistsByEmailAsync(string email);
    Task<bool> IsRiderExistsByPhoneNumberAsync(string phoneNumber);
    Task<bool> IsRiderExistsByEmailOrPhoneNumberAsync(string email, string phoneNumber);
    // CRUD
    Task<Rider> GetRiderByIdAsync(string riderId);
    Task<Rider> GetRiderByEmailAsync(string email);
    Task<Rider> GetRiderByPhoneNumberAsync(string phoneNumber);
    Task<Rider> GetRiderByEmailOrPhoneNumberAsync(string email, string phoneNumber);
    Task<Rider> RegisterRiderAsync(Rider rider);
    Task<Rider> UpdateRiderAsync(Rider rider);
    Task<bool> DeleteRiderAsync(string riderId);
}

