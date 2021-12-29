using FecPoc.Core.Aggregates;
using FecPoc.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FecPoc.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerController : ControllerBase
    {
        private readonly PartnerDataService _service;

        public PartnerController(PartnerDataService service)
        {
            _service = service;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<List<Partner>>> Get()
        {
            return await _service.GetPartners();
        }
    }
}
