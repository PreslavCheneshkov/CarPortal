using CarPortal.Core.DTOs.Offer.DropDownModels;
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
    public class DropDownService : IDropDownService
    {
        private readonly CarPortalDbContext context;
        public DropDownService(CarPortalDbContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<VehicleModelDropDown>> GetModelsAsync(int manufacturerId)
        {
            var manufacturer = await context.Manufacturers
                                            .Include(m => m.Models)
                                            .Select(m => new
                                            {
                                                Id = m.Id,
                                                Models = m.Models.Select(x => new VehicleModelDropDown()
                                                {
                                                    Id = x.Id,
                                                    Name = x.Name,
                                                })
                                            })
                                            .FirstOrDefaultAsync(m => m.Id == manufacturerId);
            return manufacturer.Models;
        }
    }
}
