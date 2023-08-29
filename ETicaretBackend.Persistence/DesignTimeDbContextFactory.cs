using ETicaretBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretBackend.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretBackendContext>
{
    public ETicaretBackendContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretBackendContext> dbContextOptionsBuilder = new();
        //dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
        dbContextOptionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ETicaretAPIDb;Username=postgres;Password=11742001");
        return new ETicaretBackendContext(dbContextOptionsBuilder.Options);
    }
}


