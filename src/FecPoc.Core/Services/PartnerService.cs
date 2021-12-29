using FecPoc.Common.Interfaces;
using FecPoc.Core.Aggregates;
using FecPoc.Core.Dto;

namespace FecPoc.Core.Services;

public class PartnerService
{
    private readonly IRepository<PartnerDto> _partnerRepository;

    public PartnerService(IRepository<PartnerDto> partnerRepository)
    {
        _partnerRepository = partnerRepository;
    }

    public async Task<List<Partner>> GetPartners()
    {
        var partnerDtos = await _partnerRepository.GetAll();

        var partners = partnerDtos
            .Select(p => new Partner(p.Id, p.Name))
            .ToList();

        return partners;
    }
}
