using CarPortal.Core.Services.Contracts;
using CarPortal.Data;
using CarPortal.Data.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CarPortal.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly CarPortalDbContext context;
        private readonly UserManager<CarPortalUser> userManager;

        public AdminService(
            CarPortalDbContext context,
            UserManager<CarPortalUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<Tuple<int, int>> GetIndexPageDataAsync()
        {   
            int offersCount = await this.context.Offers.Where(o => o.IsActive).CountAsync();
            int usersCount = await this.context.Users.CountAsync();

            return new Tuple<int, int>(offersCount, usersCount);
        }

        public async Task<List<string>> GetRolesAsync()
        {
            return await context.Roles.Select(x => x.Name).ToListAsync();
        }

        public async Task GiveRole(string roleName, string username)
        {
            if (!(await context.Users.AnyAsync(x => x.UserName == username)) || !(await this.context.Roles.AnyAsync(x => x.Name == roleName)))
            {
                throw new ArgumentException();
            }

            var user = await this.userManager.FindByNameAsync(username);
            var result = await this.userManager.AddToRoleAsync(user, roleName);

            if (!result.Succeeded)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
