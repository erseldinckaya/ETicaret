using System.ComponentModel.DataAnnotations;

namespace ETicaretBackend.Domain.Entities.Common;

public class BaseEntity
{
    [Key]
    public Guid Guid { get; set; }
    public DateTime CreatedDate { get; set; }
}