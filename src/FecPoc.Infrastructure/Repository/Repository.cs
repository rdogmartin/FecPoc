using FecPoc.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FecPoc.Infrastructure.Repository;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class, IDatabaseEntity
{
    private readonly FecContext _context;

    public Repository(FecContext context)
    {
        this._context = context;
    }
    public async Task<TEntity> Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity?> Delete(Guid id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if (entity == null)
        {
            return entity;
        }

        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<TEntity?> Find(Guid id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task<List<TEntity>> GetAll()
    {
        var items = await _context.Set<TEntity>().ToListAsync();
        return items;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }

}
