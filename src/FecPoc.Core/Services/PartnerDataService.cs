using FecPoc.Core.Aggregates;
using FecPoc.Core.Dto;
using FecPoc.Core.Interfaces;

namespace FecPoc.Core.Services;

/// <summary>
/// Contains functionality for storing and retrieving partners in the data store.
/// </summary>
public class PartnerDataService
{
    private readonly IRepository<PartnerDto> _partnerRepository;

    /// <summary>
    /// Initializes an instance of the class.
    /// </summary>
    /// <param name="partnerRepository">The repository.</param>
    public PartnerDataService(IPartnerRepository partnerRepository)
    {
        _partnerRepository = partnerRepository;
    }

    /// <summary>
    /// Retrieves all partners from the data store.
    /// </summary>
    /// <returns>A collection of partners.</returns>
    public async Task<List<Partner>> GetPartners()
    {
        var partnerDtos = await _partnerRepository.GetAll();

        var partners = partnerDtos
            .Select(p => new Partner(p.Id, p.Name))
            .ToList();

        return partners;
    }
}
