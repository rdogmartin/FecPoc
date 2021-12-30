namespace FecPoc.Common.Interfaces;

/// <summary>
/// Provides functionality for interacting with a database table.
/// </summary>
/// <typeparam name="T">An entity that maps to a row in a database table.</typeparam>
public interface IRepository<T> where T : class, IDatabaseEntity
{
    /// <summary>
    /// Gets all rows.
    /// </summary>
    Task<List<T>> GetAll();

    Task<T?> Find(Guid id);

    Task<T> Add(T entity);

    Task<T> Update(T entity);

    Task<T?> Delete(Guid id);
}
