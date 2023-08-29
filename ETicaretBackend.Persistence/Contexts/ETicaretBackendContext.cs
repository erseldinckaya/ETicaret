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
}