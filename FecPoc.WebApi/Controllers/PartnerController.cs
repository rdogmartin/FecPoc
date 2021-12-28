using FecPoc.Core.Aggregates;
using FecPoc.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FecPoc.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerController : ControllerBase
    {
        private readonly PartnerService _service;

        public PartnerController(PartnerService service)
        {
            _service = service;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partner>>> Get()
        {
            return await _service.GetPartners();
        }
    }
}