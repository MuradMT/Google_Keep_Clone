
namespace Application.Interfaces.UnitOfWorks;

public interface IUnitOfWork<TEntity, TContext> : IDisposable
 where TEntity : class, IEntity, new()
 where TContext : DbContext
{
    IRepository<TEntity> Repository { get; }
}