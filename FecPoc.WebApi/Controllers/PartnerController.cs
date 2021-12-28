using FecPoc.Core.Aggregates;
using FecPoc.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FecPoc.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerController : FecBaseController<Partner, PartnerRepository>
    {
        public PartnerController(PartnerRepository repository) : base(repository)
        {
        }
    }
}