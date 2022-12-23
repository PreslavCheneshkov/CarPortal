using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Profile;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.User;
using Microsoft.EntityFrameworkCore;

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
            bool userExists = await context.Users.AnyAsync(u => u.UserName == username);
            CarPortalUser user;

            if (userExists)
            {
                user = await context.Users.FirstAsync(u => u.UserName == username);
            }
            else 
            {
                throw new NullReferenceException("Such a user does not exist.");
            }

            CarPortalProfile profile = new CarPortalProfile()
            {
                CarPortalUserId = user.Id,
                IsDealer = isDealer,
            };

            await context.Profiles.AddAsync(profile);
            user.ProfileId = profile.Id;
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
                UserId = u.Id
            }).FirstOrDefaultAsync(p => p.UserName == username);

            if (profile == null)
            {
                throw new NullReferenceException("There is no such profile.");
            }

            profile.UploadedOffers = await context.Offers
                                                   .Where(o => o.SellerId == profile.UserId)
                                                   .Where(o => o.IsActive)
                                                   .OrderByDescending(x => x.CreatedOn)
                                                   .Select(o => new OfferInCollectionDto()
                                                   {
                                                       FuelType = o.Car.FuelType.Name,
                                                       HorsePower = o.Car.HorsePower,
                                                       Manufacturer = o.Car.Manufacturer.Name,
                                                       Mileage = o.Car.Mileage,
                                                       Model = o.Car.Model.Name,
                                                       OfferId = o.Id,
                                                       OfferName = o.Name,
                                                       Price = o.Price,
                                                       ThumbnailUrl = $"/Images/Offers/Thumbnails/{o.OfferThumbnail.Id}{o.OfferThumbnail.Extension}",
                                                       TransmissionType = o.Car.TransmissionType.Name,
                                                       Year = o.Car.Year,
                                                   })
                                                   .ToListAsync();

            return profile;
        }
    }
}
