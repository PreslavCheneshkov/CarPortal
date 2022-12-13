using CarPortal.Core.DTOs.Profile;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class ProfileService : IProfileService
    {
        private readonly CarPortalDbContext context;

        public ProfileService(CarPortalDbContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateProfileAsync(string username, bool isDealer)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == username);
            string? userId = user.Id;

            if (string.IsNullOrEmpty(userId))
            {
                throw new NullReferenceException("Such a user does not exist.");
            }

            CarPortalProfile profile = new CarPortalProfile()
            {
                CarPortalUserId = userId,
                IsDealer = isDealer,
            };

            user.Profile = profile;
            await context.Profiles.AddAsync(profile);
            await context.SaveChangesAsync();

            return profile.Id;
        }

        public async Task<ProfileDto> GetProfileByUsernameAsync(string username)
        {
            ProfileDto? profile = await context.Users.Select(u => new ProfileDto()
            {
                ProfilePictureAddress = u.Profile.ProfilePictureAdress,
                IsDealer = u.Profile.IsDealer,
                ProfileId = u.ProfileId,
                UserName = u.UserName,
                CreatedOn = u.Profile.CreatedDate,
            }).FirstOrDefaultAsync(p => p.UserName == username);

            if (profile == null)
            {
                throw new NullReferenceException("There is no such profile.");
            }

            return profile;
        }
    }
}
