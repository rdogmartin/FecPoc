using System.Linq.Expressions;

namespace FecPoc.Core.Interfaces;

/// <summary>
/// Provides functionality for interacting with a database table.
/// </summary>
/// <typeparam name="T">An entity that maps to a row in a database table.</typeparam>
public interface IRepository<T> where T : class, IDatabaseEntity
{
    /// <summary>
    /// Finds an entity with the given primary key values. If an entity with the given primary key values is being tracked by the context,
    /// then it is returned immediately without making a request to the database. Otherwise, a query is made to the database for an entity
    /// with the given primary key values and this entity, if found, is attached to the context and returned. If no entity is found, then
    /// null is returned.
    /// </summary>
    /// <param name="id">The value of the primary key for the entity to be found.</param>
    /// <returns><typeparamref name="T"/></returns>
    ValueTask<T?> Find(Guid id);

    /// <summary>
    /// Gets all rows from the data store.
    /// </summary>
    /// <returns>Task{List{T}}</returns>
    Task<List<T>> GetAll();

    /// <summary>
    /// Filters a sequence of values based on the <paramref name="predicate" /> and including the <paramref name="includeProperties" />.
    /// </summary>
    /// <param name="predicate">The predicate.</param>
    /// <param name="includeProperties">The include properties.</param>
    /// <returns>IQueryable&lt;T&gt;.</returns>
    IQueryable<T> Where(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    /// <summary>
    /// Adds the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    void Add(T entity);

    /// <summary>
    /// Adds the specified entities.
    /// </summary>
    /// <param name="entities"></param>
    void AddRange(IEnumerable<T> entities);

    /// <summary>
    /// Removes the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    void Remove(T entity);

    /// <summary>
    /// Removes the specified entities.
    /// </summary>
    /// <param name="entities"></param>
    void RemoveRange(IEnumerable<T> entities);

    /// <summary>
    /// Saves all changes made in this context to the underlying data store.
    /// </summary>
    /// <returns><see cref="Task" /></returns>
    Task Save();
}
