namespace Persistence.UnitOfWorks;

public class UnitOfWork<TEntity, TContext>(TContext _context) : IUnitOfWork<TEntity,TContext>
    where TEntity : class, IEntity,new()
    where TContext : DbContext
{
    IRepository<TEntity> _repository;
    public IRepository<TEntity> Repository => _repository ?? new Repository<TEntity, TContext>(_context);

    public void Dispose()
    {
        _context.Dispose();
    }
}