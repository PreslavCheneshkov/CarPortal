﻿using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Search;
using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services
{
    public class SearchService : ISearchService
    {
        private readonly CarPortalDbContext context;

        public SearchService(CarPortalDbContext context)
        {
            this.context = context;
        }

        public async Task<List<OfferInCollectionDto>> GetSearchResultsAsync(SearchModelDto inputModel)
        {
            var offers = context.Offers.AsQueryable();
            List<OfferInCollectionDto> results = new List<OfferInCollectionDto>();

            if (inputModel.VehicleCategoryId != null)
            {
                offers = offers.Where(o => o.Car.VehicleCategoryId == inputModel.VehicleCategoryId);
            }

            if (inputModel.ManufacturerId != null)
            {
                offers = offers.Where(o => o.Car.ManufacturerId == inputModel.ManufacturerId);
            }

            if (inputModel.ModelId != null)
            {
                offers = offers.Where(o => o.Car.ModelId == inputModel.ModelId);
            }

            if (inputModel.MinEngineDisplacement != null && inputModel.MinEngineDisplacement >= 0)
            {
                offers = offers.Where(o => o.Car.EngineDisplacement >= inputModel.MinEngineDisplacement);
            }

            if (inputModel.MaxEngineDisplacement != null && inputModel.MaxEngineDisplacement >= 0)
            {
                offers = offers.Where(o => o.Car.EngineDisplacement <= inputModel.MaxEngineDisplacement);
            }

            if (inputModel.MinHorsePower != null && inputModel.MinHorsePower >= 0)
            {
                offers = offers.Where(o => o.Car.HorsePower >= inputModel.MinHorsePower);
            }

            if (inputModel.MaxHorsePower != null && inputModel.MaxHorsePower >= 0)
            {
                offers = offers.Where(o => o.Car.HorsePower <= inputModel.MaxHorsePower);
            }

            if (inputModel.MinYear != null && inputModel.MinYear >= 1900 && inputModel.MinYear <= DateTime.UtcNow.Year)
            {
                offers = offers.Where(o => o.Car.Year >= inputModel.MinYear);
            }

            if (inputModel.MaxYear != null && inputModel.MaxYear >= 1900 && inputModel.MaxYear <= DateTime.UtcNow.Year)
            {
                offers = offers.Where(o => o.Car.Year <= inputModel.MaxYear);
            }

            if (inputModel.MaxMileage != null && inputModel.MaxMileage >= 0)
            {
                offers = offers.Where(o => o.Car.Mileage >= inputModel.MaxMileage);
            }

            if (inputModel.MinPrice != null && inputModel.MinPrice >= 0)
            {
                offers = offers.Where(o => o.Price >= inputModel.MinPrice);
            }

            if (inputModel.MaxPrice != null && inputModel.MaxPrice >= 0)
            {
                offers = offers.Where(o => o.Price <= inputModel.MaxPrice);
            }

            if (inputModel.ExtraIds != null && inputModel.ExtraIds.Length > 0)
            {
                foreach (var extraId in inputModel.ExtraIds)
                {
                    offers = offers.Where(o => o.Car.Extras.Any(x => x.ExtraId == extraId));
                }
            }

            if (inputModel.ColorIds != null && inputModel.ColorIds.Length > 0)
            {
                offers = offers.Where(o => inputModel.ColorIds.Contains(o.Car.ColorId));
            }

            if (inputModel.FuelTypeIds != null && inputModel.FuelTypeIds.Length > 0)
            {
                offers = offers.Where(o => inputModel.FuelTypeIds.Contains(o.Car.FuelTypeId));
            }

            if (inputModel.TransmissionTypeIds != null && inputModel.TransmissionTypeIds.Length > 0)
            {
                offers = offers.Where(o => inputModel.TransmissionTypeIds.Contains(o.Car.TransmissionTypeId));
            }

            if (inputModel.RegionIds != null && inputModel.RegionIds.Length > 0)
            {
                offers = offers.Where(o => inputModel.RegionIds.Contains(o.RegionId));
            }

            if (!string.IsNullOrEmpty(inputModel.Keyword))
            {
                offers = offers.Where(o => EF.Functions.Like(o.AdditionalInfo, $"%{inputModel.Keyword}%") || EF.Functions.Like(o.Name, $"%{inputModel.Keyword}%"));
            }

            if (inputModel.FromDealer != null)
            {
                offers = offers.Where(o => o.Seller.Profile.IsDealer == (bool)inputModel.FromDealer);
            }

            results = await offers.Select(o => new OfferInCollectionDto()
            {
                OfferName = o.Name,
                OfferId = o.Id,
                TransmissionType = o.Car.TransmissionType.Name,
                Manufacturer = o.Car.Manufacturer.Name,
                Model = o.Car.Model.Name,
                HorsePower = o.Car.HorsePower,
                FuelType = o.Car.FuelType.Name,
                Mileage = o.Car.Mileage,
                Year = o.Car.Year,
                Price = o.Price,
                AddedOn = o.CreatedOn,
                ThumbnailUrl = $"/Images/Offers/Thumbnails/{o.OfferThumbnail.Id}{o.OfferThumbnail.Extension}",
            }).ToListAsync();

            if (!string.IsNullOrEmpty(inputModel.OrderBy))
            {
                switch (inputModel.OrderBy)
                {
                    case "Price Ascending": results = results.OrderBy(r => r.Price).ToList(); break;
                    case "Price Descending": results = results.OrderByDescending(r => r.Price).ToList(); break;
                    case "Most recently added": results = results.OrderByDescending(r => r.AddedOn).ToList(); break;
                    case "Year Ascending": results = results.OrderBy(r => r.Year).ToList(); break;
                    case "Year Descending": results = results.OrderByDescending(r => r.Year).ToList(); break;
                    default:
                        break;
                }
            }

            //todo: pagination and order

            return results;
        }
    }
}
