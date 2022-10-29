using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.Data
{
    public class CarPortalDbContext : IdentityDbContext
    {
        public CarPortalDbContext(DbContextOptions<CarPortalDbContext> options)
            : base(options)
        {
        }
    }
}