using ETicaretBackend.Domain.Entities.Common;

namespace ETicaretBackend.Domain.Entities;

public class Product : BaseEntity
{
    public String Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
    
    public ICollection<Order> Orders { get; set; }
}