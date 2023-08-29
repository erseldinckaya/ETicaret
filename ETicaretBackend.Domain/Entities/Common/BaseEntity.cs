using System.ComponentModel.DataAnnotations;

namespace ETicaretBackend.Domain.Entities.Common;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}