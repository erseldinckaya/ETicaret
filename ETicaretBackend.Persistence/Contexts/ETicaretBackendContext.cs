using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretBackend.Persistence.Contexts;

public class ETicaretBackendContext : DbContext
{
    public ETicaretBackendContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        //ChangeTracker: Entityler üzerinden yapılan değişikliklerin ya da yeni eklenen verilerin yakalanmasını sağlayan propertydir.
        // Track edilen verileri yakalayıp elde etmemizi sağlar.

        var datas = ChangeTracker.Entries<BaseEntity>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow
            };
        }
        
        return await base.SaveChangesAsync(cancellationToken);
    }
}