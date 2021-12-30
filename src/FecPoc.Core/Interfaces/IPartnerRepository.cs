using FecPoc.Core.Dto;

namespace FecPoc.Core.Interfaces;

/// <summary>
/// Extends the standard repository to contain functionality specific to a partner.
/// This can be used if the generic <c>IRepository{T}</c> has insufficient capability.
/// </summary>
public interface IPartnerRepository : IRepository<PartnerDto>
{
    /// <summary>
    /// An example method containing functionality specific to a partner.
    /// </summary>
    IEnumerable<PartnerDto> GetActivePartners();
}
