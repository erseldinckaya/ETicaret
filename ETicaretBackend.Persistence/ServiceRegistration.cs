using ETicaretBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretBackend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ETicaretBackendContext>(options =>
            //options.UseNpgsql(Configuration.ConnectionString));
            options.UseNpgsql("Host=localhost;Port=5432;Database=ETicaretAPIDb;Username=postgres;Password=11742001"));
    }
}