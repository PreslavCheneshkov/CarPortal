using CarPortal.Core.DTOs.Profile;

namespace CarPortal.Core.Services.Contracts
{
    public interface IProfileService
    {
        Task<string> CreateProfileAsync(string username, bool isDealer);

        Task<ProfileDto> GetProfileByUsernameAsync(string username);
    }
}
