using Kreata.Context;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Extensions
{
    public static class KretaBackendExtension
    {
        public static void AddBackend(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureInMemoryContext();
        }

        private static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
                 option.AddPolicy(name: "KreataCors",
                     policy =>
                     {
                         policy.WithOrigins("https://0.0.0.0:7020/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "Kreta" + Guid.NewGuid();
            services.AddDbContext<KreataInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }
    }
}
