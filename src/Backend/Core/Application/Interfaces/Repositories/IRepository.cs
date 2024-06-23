namespace Application.Interfaces.Repositories;

public interface IRepository<T>
where T:class,IEntity,new()
{
      Task<List<T>> GetAllAsync();
      Task<T?> GetByIdAsync(int id);
      Task AddAsync(T entity);
      Task UpdateAsync(T entity);
      Task DeleteAsync(T entity);
}
