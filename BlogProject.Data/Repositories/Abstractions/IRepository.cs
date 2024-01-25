using System.Linq.Expressions;
using BlogProject.Core.Entities;

namespace BlogProject.Data.Repositories.Abstractions;

public interface IRepository<T> where T :class,IEntityBase,new()
{
    Task AddAsync(T entity);

    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] inculudeProperties);

    Task<T> GetAsync(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] inculudeProperties);

    Task<T> GetByGuidAsync(Guid id);

    Task<T> UpdateAsync(T entity);

    Task DeleteAsync(T entity);
    
    Task HardDeleteAsync(T entity);

    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    
    Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
}