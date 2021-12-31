using System.Linq.Expressions;
using FecPoc.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FecPoc.Infrastructure.Repository;

/// <inheritdoc />
public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class, IDatabaseEntity
{
    private readonly FecContext _context;

    /// <summary>
    /// Initialize an instance of this class.
    /// </summary>
    /// <param name="context">A database context.</param>
    public Repository(FecContext context)
    {
        this._context = context;
    }

    /// <inheritdoc />
    public ValueTask<TEntity?> Find(Guid id)
    {
        return _context.Set<TEntity>().FindAsync(id);
    }

    /// <inheritdoc />
    public async Task<List<TEntity>> GetAll()
    {
        var items = await _context.Set<TEntity>().ToListAsync();
        return items;
    }

    /// <inheritdoc />
    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);

        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return query;
    }

    /// <inheritdoc />
    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }

    /// <inheritdoc />
    public void AddRange(IEnumerable<TEntity> entities)
    {
        _context.Set<TEntity>().AddRange(entities);
    }

    /// <inheritdoc />
    public void Remove(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    /// <inheritdoc />
    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _context.Set<TEntity>().RemoveRange(entities);
    }

    /// <inheritdoc />
    public async Task Save()
    {
        await _context.SaveChangesAsync();
    }
}
