using CarPortal.Data;
using Microsoft.EntityFrameworkCore;

namespace CarPortal.API.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();
            var dbContext = services.ServiceProvider.GetService<CarPortalDbContext>();
            dbContext?.Database.Migrate();
        }
    }
}
