using FecPoc.Core.Aggregates;
using FecPoc.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FecPoc.WebApi.Controllers;

/// <summary>
/// Contains API endpoints for the partner domain.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PartnerController : ControllerBase
{
    private readonly PartnerDataService _service;

    /// <summary>
    /// Initializes an instance of the class.
    /// </summary>
    /// <param name="service">An instance of <see cref="PartnerDataService" /></param>
    public PartnerController(PartnerDataService service)
    {
        _service = service;
    }

    /// <summary>
    /// Gets a list of partners.
    /// GET: api/[controller]
    /// </summary>
    /// <returns>A list of partners.</returns>
    [HttpGet]
    public async Task<ActionResult<List<Partner>>> Get()
    {
        return await _service.GetPartners();
    }
}
