using CarPortal.Core.Dtos.Offer.DropDownModels;
using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.Car;
using CarPortal.Data.Entities.Offer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly CarPortalDbContext context;
        private readonly IWebHostEnvironment environment;

        private readonly string[] allowedImageExtensions = { ".jpg", ".jpeg", ".png"};
        private string wwwrootPath;

        public OfferService(
            CarPortalDbContext _context,
            IWebHostEnvironment _environment
            )
        {
            environment = _environment;
            context = _context;
            wwwrootPath = environment.WebRootPath;
            Directory.CreateDirectory($"{wwwrootPath}/Images/Offer");
        }

        public async Task AddOfferAsync(OfferInputModel inputModel, string sellerId)
        {
            Car car = new Car()
            {
                VehicleCategoryId = inputModel.Car.VehicleCategoryId,
                ManufacturerId = inputModel.Car.ManufacturerId,
                ModelId = inputModel.Car.ModelId,
                FuelTypeId = inputModel.Car.FuelTypeId,
                TransmissionTypeId = inputModel.Car.TransmissionTypeId,
                EngineDisplacement = inputModel.Car.EngineDisplacement,
                ColorId = inputModel.Car.ColorId,
                Year = inputModel.Car.Year,
                IsBrandNew = inputModel.Car.IsBrandNew,
                Mileage = inputModel.Car.Mileage,
            };

            Offer offer = new Offer()
            {
                Car = car,
                CreatedOn = DateTime.UtcNow,
                LastEdited = DateTime.UtcNow,
                AdditionalInfo = inputModel.AdditionalInfo,
                SellerId = sellerId,
                CityId = inputModel.CityId,
                RegionId = inputModel.RegionId,
                Price = inputModel.Price,
                ContactPhoneNumber = inputModel.ContactPhoneNumber,
            };

            OfferThumbnail thumbnail = new OfferThumbnail()
            {
                Offer = offer,
                Extension = Path.GetExtension(inputModel.Thumbnail.FileName),
            };
            if (!allowedImageExtensions.Contains(thumbnail.Extension))
            {
                throw new FormatException("Image extension not allowed");
            }

            string thumbnailPath = $"{wwwrootPath}/Images/Offers/Thumbnails/{thumbnail.Id}{thumbnail.Extension}";

            using (Stream fileStream = new FileStream(thumbnailPath, FileMode.Create))
            {
                await inputModel.Thumbnail.CopyToAsync(fileStream);
            }

            List<CarImage> images = new List<CarImage>();

            foreach (var imageInput in inputModel.Images)
            {
                CarImage image = new CarImage()
                {
                    Offer = offer,
                    Extension = Path.GetExtension(imageInput.FileName),
                };
                if (!allowedImageExtensions.Contains(image.Extension))
                {
                    throw new FormatException("Image extension not allowed");
                }
                images.Add(image);

                string physicalPath = $"{wwwrootPath}/Images/Offers/{image.Id}{image.Extension}";
                using (Stream fileStream = new FileStream(physicalPath, FileMode.Create))
                {
                    await imageInput.CopyToAsync(fileStream);
                }
            }

            offer.Images = images;
            offer.OfferThumbnail = thumbnail;
            await context.Offers.AddAsync(offer);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SeeAllOffersDto>> GetAllOffers()
        {
            var offers = await context.Offers
                                      .Select(o => new SeeAllOffersDto
                                      {
                                          OfferId = o.Id,
                                          Manufacturer = o.Car.Manufacturer.Name,
                                          Model = o.Car.Model.Name,
                                          FuelType = o.Car.FuelType.Name,
                                          Year = o.Car.Year,
                                          Mileage = o.Car.Mileage,
                                          ContactPhone = o.ContactPhoneNumber,
                                          Price = o.Price,
                                          ThumbnailUrl = $"/Images/Offers/Thumbnails/{o.OfferThumbnail.Id}{o.OfferThumbnail.Extension}",
                                      }).ToArrayAsync();
            
            return offers;
        }

        public async Task<SingleOfferDto> GetOfferByIdAsync(int offerId)
        {
            var offer = await context.Offers
                                       .Select(o => new SingleOfferDto()
                                       {
                                           Id = o.Id,
                                           CarDto = new CarInSingleOfferDto()
                                           {
                                               VehicleCategory = o.Car.VehicleCategory.Name,
                                               Manufacturer = o.Car.Manufacturer.Name,
                                               Model = o.Car.Manufacturer.Name,
                                               FuelType = o.Car.FuelType.Name,
                                               TransmissionType = o.Car.TransmissionType.Name,
                                               Color = o.Car.Color.Name,
                                               Year = o.Car.Year,
                                               Mileage = o.Car.Mileage,
                                               IsBrandNew = o.Car.IsBrandNew,
                                               Extras = o.Car.Extras.Select(e => e.Name).ToList(),
                                           },
                                           SellerId = o.SellerId,
                                           SellerName = o.Seller.UserName,
                                           City = o.City.Name,
                                           Region = o.Region.Name,
                                           ContactPhoneNumber = o.ContactPhoneNumber,
                                           LastEdited = o.LastEdited,
                                           ThumbnailUrl = $"/Images/Offers/Thumbnails/{o.OfferThumbnail.Id}{o.OfferThumbnail.Extension}",
                                           PictureIds = o.Images.Select(i => $"/Images/Offers/{ i.Id + i.Extension}").ToList()
                                       })
                                       .FirstOrDefaultAsync(o => o.Id == offerId);

            return offer;
        }

        public async Task<OfferDropDownsModel> PopulateViewModelWithDropDownsAsync()
        {
            var regions = await context.Regions.Select(r => new RegionDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var cities = await context.Cities.Select(r => new CityDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var colors = await context.Colors.Select(r => new ColorDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var fuelTypes = await context.FuelTypes.Select(r => new FuelTypeDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var manufacturers = await context.Manufacturers.Select(r => new ManufacturerDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var transmissionTypes = await context.TransmissionTypes.Select(r => new TransmissionTypeDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var vehicleCategories = await context.VehicleCategories.Select(r => new VehicleCategoryDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            var vehicleModels = await context.Models.Select(r => new VehicleModelDropDown
            {
                Name = r.Name,
                Id = r.Id,
            }).ToArrayAsync();

            OfferDropDownsModel model = new OfferDropDownsModel()
            {
                Cities = cities,
                Colors = colors,
                FuelTypes = fuelTypes,
                Manufacturers = manufacturers,
                TransmissionTypes = transmissionTypes,
                VehicleCategories = vehicleCategories,
                VehicleModels = vehicleModels,
                Regions = regions,
            };

            return model;
        }
    }
}
