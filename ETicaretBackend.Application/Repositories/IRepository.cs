using ETicaretBackend.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretBackend.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}