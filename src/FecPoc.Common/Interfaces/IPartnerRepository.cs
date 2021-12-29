namespace FecPoc.Common.Interfaces;

public interface IPartnerRepository<TEntity> : IRepository<TEntity> where TEntity : class, IDatabaseEntity
{
    void DoSpecificPartnerLogic();
}
