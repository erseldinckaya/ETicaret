using ETicaretBackend.Application.Repositories;
using ETicaretBackend.Persistence.Contexts;
using ETicaretBackend.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretBackend.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ETicaretBackendContext>(options =>
            //options.UseNpgsql(Configuration.ConnectionString));
            options.UseNpgsql("Host=localhost;Port=5432;Database=ETicaretAPIDb;Username=postgres;Password=11742001"),
            ServiceLifetime.Singleton);


        services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
        services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
        
        services.AddSingleton<IProductReadRepository, ProductReadRepository>();
        services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        
        services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
        services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
    }
}