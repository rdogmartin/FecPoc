using FecPoc.Core.Dto;
using FecPoc.Core.Interfaces;

namespace FecPoc.Infrastructure.Repository;

/// <summary>
/// A repository for the <see cref="PartnerDto" /> entity that provides DB functionality specific to partners.
/// This can be used if the generic <c>IRepository{Partner}</c> has insufficient capability.
/// </summary>
/// <example>
/// To use this, specify this class where DI is configured, then update injected locations to use
/// <c>IPartnerRepository{Partner}</c> instead of <c>IRepository{Partner}</c>.
/// <code>
/// services.AddScoped{IPartnerRepository{Partner}, PartnerRepository}();
/// </code>
/// </example>
public class PartnerRepository : Repository<PartnerDto>, IPartnerRepository
{
    /// <summary>
    /// Initializes an instance of the class.
    /// </summary>
    /// <param name="context">The database context.</param>
    public PartnerRepository(FecContext context) : base(context)
    {
    }

    /// <inheritdoc />
    public IEnumerable<PartnerDto> GetActivePartners()
    {
        throw new NotImplementedException();
    }
}
