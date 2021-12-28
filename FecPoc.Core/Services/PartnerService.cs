using FecPoc.Common.Interfaces;
using FecPoc.Core.Aggregates;

namespace FecPoc.Core.Services;

public class PartnerService
{
    private readonly IRepository<Partner> _partnerRepository;

    public PartnerService(IRepository<Partner> partnerRepository)
    {
        _partnerRepository = partnerRepository;
    }

    public async Task<List<Partner>> GetPartners()
    {
        var partners = await _partnerRepository.GetAll();
    
        return partners;
    }
}