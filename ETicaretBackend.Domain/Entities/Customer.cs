using ETicaretBackend.Domain.Entities.Common;

namespace ETicaretBackend.Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}