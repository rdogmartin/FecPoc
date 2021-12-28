using FecPoc.Common.Interfaces;
using FecPoc.Core.Aggregates;

namespace FecPoc.Infrastructure.Repository;

/// <summary>
/// 
/// </summary>
public class PartnerRepository : Repository<Partner>
{
    public PartnerRepository(FecContext context) : base(context)
    {

    }

    // We can add new methods specific to the partner repository here in the future
    public void DoSpecificPartnerLogic()
    {
        throw new NotImplementedException();
    }
}