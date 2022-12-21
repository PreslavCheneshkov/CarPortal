using CarPortal.Core.DTOs.Offer;
using CarPortal.Core.DTOs.Offer.DropDownModels;
using CarPortal.Core.DTOs.Search;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface IPageDataService
    {
        Task<List<VehicleModelDropDown>> GetModelsAsync(int manufacturerId);

        Task<OfferDropDownsModel> PopulateViewModelWithDropDownsAsync();

        Task<SearchInputModel> PopulateSearchModelAsync();
    }
}
