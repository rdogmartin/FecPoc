namespace FecPoc.Common.Interfaces;

public interface IPartnerRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    void DoSpecificPartnerLogic();
}