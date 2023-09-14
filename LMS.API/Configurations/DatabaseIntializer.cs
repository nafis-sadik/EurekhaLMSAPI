using LMS.Entities;
using Microsoft.EntityFrameworkCore;
using RedBook.Core.Constants;

namespace LMS.API.Configurations
{
    public static class DatabaseIntializer
    {
        public static void InitDatabase(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                EurekhaLmsContext context = scope.ServiceProvider.GetRequiredService<EurekhaLmsContext>();
                                
                // Only run database migrations in development environment
                if (env.IsDevelopment())
                {
                    if (context.Database.GetPendingMigrations().Any())
                    {
                        context.Database.Migrate();
                    }
                }
            }
        }
    }
}
