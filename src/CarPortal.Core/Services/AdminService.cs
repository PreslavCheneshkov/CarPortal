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
    public class AdminService : IAdminService
    {
        private readonly CarPortalDbContext context;

        public AdminService(CarPortalDbContext context)
        {
            this.context = context;
        }

        public async Task<Tuple<int, int>> GetIndexPageData()
        {   
            int offersCount = await this.context.Offers.Where(o => o.IsActive).CountAsync();
            int usersCount = await this.context.Users.CountAsync();

            return new Tuple<int, int>(offersCount, usersCount);
        }
    }
}
