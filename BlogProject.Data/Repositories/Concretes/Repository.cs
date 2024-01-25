using System.Linq.Expressions;
using BlogProject.Core.Entities;
using BlogProject.Data.Context;
using BlogProject.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogProject.Data.Repositories.Concretes;

public class Repository<T> : IRepository<T> where T : class,IEntityBase,new()
{
    private readonly AppDbContext dbContext;

    public Repository(AppDbContext dbContext)
    {
        dbContext = dbContext;
    }
    public DbSet<T> Table
    {
        get => dbContext.Set<T>();
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] inculudeProperties)
    {
        IQueryable<T> query = Table;
        if (predicate != null)
        {
            query = query.Where(predicate);
            
        }

        if (inculudeProperties.Any())
        {
            foreach (var item in inculudeProperties)
            {
                query = query.Include(item);
            }
        }

        return await query.ToListAsync();
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] inculudeProperties)
    {
        IQueryable<T> query = Table;
        query = query.Where(predicate);

        if (inculudeProperties.Any())
        {
            foreach (var item in inculudeProperties)
            {
                query = query.Include(item);
            }
        }
        
        return await query.SingleOrDefaultAsync();
    }

    public async Task<T> GetByGuidAsync(Guid id)
    {
        return await Table.FindAsync();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        await Task.Run(() => Table.Update(entity));
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        await Task.Run(() => Table.Remove(entity));
        
    }

    public Task HardDeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        return await Table.AnyAsync(predicate);
    }

    public Task<bool> CountAsync(Expression<Func<T, int>> predicate = null)
    {
        throw new NotImplementedException();
    }

    public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
    {
        return await Table.CountAsync(predicate);
    }
    
    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
    }
}