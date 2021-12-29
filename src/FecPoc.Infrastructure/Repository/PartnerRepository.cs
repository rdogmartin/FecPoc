using FecPoc.Common.Interfaces;
using FecPoc.Core.Aggregates;
using FecPoc.Core.Dto;

namespace FecPoc.Infrastructure.Repository;

/// <summary>
/// A repository for the <see cref="PartnerDto" /> entity that provides DB functionality specific to partners.
/// This can be used if the generic <see cref="IRepository&lt;Partner&gt;"/> has insufficient capability.
/// </summary>
/// <example>
/// To use this, specify this class where DI is configured, then update injected locations to use
/// <see cref="IPartnerRepository&lt;Partner&gt;" /> instead of <see cref="IRepository&lt;Partner&gt;"/>.
/// <code>
/// services.AddScoped&lt;IPartnerRepository&lt;Partner&gt;, PartnerRepository&gt;();
/// </code>
/// </example>
public class PartnerRepository : Repository<PartnerDto>, IPartnerRepository<PartnerDto>
{
    public PartnerRepository(FecContext context) : base(context)
    {
    }

    // We can add methods specific to the partner repository here.
    public void DoSpecificPartnerLogic()
    {
        throw new NotImplementedException();
    }
}
