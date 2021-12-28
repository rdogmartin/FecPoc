using FecPoc.Common.Interfaces;
using FecPoc.Core.Aggregates;

namespace FecPoc.Core.Services;

public class PartnerService
{
    private readonly IPartnerRepository _partnerRepository;

    public PartnerService(IPartnerRepository partnerRepository)
    {
        _partnerRepository = partnerRepository;
    }

    // public async Task<IEnumerable<Partner>> GetPartners()
    // {
    //     var partners = await _partnerRepository.ListAsync();
    //
    //     return partners;
    // }
}