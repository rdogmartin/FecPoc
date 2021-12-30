namespace FecPoc.Core.Interfaces;

/// <summary>
/// Extends the standard repository to contain functionality specific to a partner.
/// This can be used if the generic <c>IRepository{T}</c> has insufficient capability.
/// </summary>
/// <typeparam name="TEntity">The database entity.</typeparam>
public interface IPartnerRepository<TEntity> : IRepository<TEntity> where TEntity : class, Core.Interfaces.IDatabaseEntity
{
    /// <summary>
    /// An example method containing functionality specific to a partner.
    /// </summary>
    void DoSpecificPartnerLogic();
}
