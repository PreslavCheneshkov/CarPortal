using CarPortal.Core.DTOs.Offer.DropDownModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Core.Services.Contracts
{
    public interface IDropDownService
    {
        Task<IEnumerable<VehicleModelDropDown>> GetModelsAsync(int manufacturerId);
    }
}
